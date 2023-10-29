# require
require 'gosu'

# FR: Class 'Fenetre' qui hérite de 'Gosu::Window'
class Fenetre < Gosu::Window
  def initialize
    super(800, 600) # window sizing
    self.caption = 'Bouton Gosu' # window title

    # init
    @tirage = false
    @frame = 0

    # FR: bouton qui effectuera le tirage
    # EN: button that will make the draw
    @button_x = 300
    @button_y = 350
    @button_width = 200
    @button_height = 60
    @button_color = Gosu::Color::WHITE

    # FR: police
    # EN: font
    @font = Gosu::Font.new(24)

    # FR: ouvre et enregistre les utilisateurs dans un tableau
    # EN: opens and registers users in a table
    @tab_utilisateur = open("utilisateur.txt").map(&:chomp)

    # libelle
    @button_text = 'Cliquez-moi!'
    @text_center = 'QUI VA GAGNER ?'
  end

  # FR: Cette méthode est appelée une fois toutes les #update_interval millisecondes pendant l'affichage de la fenêtre.
  # EN: This method is called once every #update_interval milliseconds while the window is being shown.
  def update
    
    # FR: vérifie si le bouton est survolé et cliquer pour savoir si le tirage doit être lancer ou non
    # EN: check if the button is hovered over and click to see if the print should be launched or not
    if survole_bouton
          @button_color = Gosu::Color::AQUA
        if Gosu.button_down?(Gosu::MsLeft)
            @button_color = Gosu::Color::GRAY
            @tirage = true
        end
    else
        @button_color = Gosu::Color::WHITE
    end

    # FR: lance un tirage
    # EN: launches a draw
    if @tirage

      @frame+=1
      
      # FR: Toutes les 5 frames un nom s'affiche au hasard à l'écran
      # EN: Every 5 frames a name is randomly displayed on the screen
      if @frame % 5 == 0
          # FR: génère un nombre aléatoire
          # EN: generates a random number
          utilisateur_random = rand(@tab_utilisateur.length)

          # FR: @text_center sera le nouveau nom afficher
          # EN: @text_center will be the new display name
          @text_center = @tab_utilisateur[utilisateur_random]
      end

      # FR: si 100 frames sont passé alors arrêter le tirage
      # EN: if 100 frames have passed, stop the draw
      if @frame > 100
          @tirage = false
          @frame = 0
      end
    end
  end

  # FR: Cette méthode est appelée après chaque mise à jour et chaque fois que le système d'exploitation souhaite que la fenêtre se repeint
  # EN: This method is called after every update and whenever the OS wants the window to repaint itself
  def draw
    # FR: Dessine le bouton
    # EN: Draw the button
    Gosu.draw_rect(@button_x, @button_y, @button_width, @button_height, @button_color, 1)
  
    # FR: positionne le texte du bouton
    # EN: positions button text
    button_text_width = @font.text_width(@button_text)
    button_text_x = @button_x + (@button_width - button_text_width) / 2
    button_text_y = @button_y + (@button_height - @font.height) / 2
  
    # FR: positionne le texte au centre de la fenêtre
    # EN: positions text in the center of the window
    text_center_width = @font.text_width(@text_center)
    text_center_x = (800 - text_center_width*2) / 2
    text_center_y = (600 - @font.height-100) / 2
  
    # draw
    @font.draw(@button_text, button_text_x, button_text_y, 10, 1, 1, Gosu::Color::BLACK)
    @font.draw(@text_center, text_center_x, text_center_y, 10, 2, 2, Gosu::Color::WHITE)
  end
  
  # FR: renvoie vrai si le bouton est survolé
  # EN: returns true if the button is hovered over
  def survole_bouton
    x = mouse_x
    y = mouse_y

    if x > @button_x && x < @button_x + @button_width && y > @button_y && y < @button_y + @button_height
        return true
    else
        return false
    end
  end
  
  # FR: si le curseur système doit être affiché
  # EN: whether the system cursor should be shown
  def needs_cursor?
    true
  end
end

fenetre = Fenetre.new
fenetre.show
