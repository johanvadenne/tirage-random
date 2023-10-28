require 'gosu'

class Fenetre < Gosu::Window
  def initialize
    super(800, 600)
    self.caption = 'Bouton Gosu'

    @tirage = false
    @frame = 0

    @button_x = 300
    @button_y = 350
    @button_width = 200
    @button_height = 60
    @button_color = Gosu::Color::WHITE

    @font = Gosu::Font.new(24)

    # Charge la liste des utilisateurs depuis un fichier
    @tab_utilisateur = File.readlines('utilisateur.txt').map(&:chomp)

    # Texte du bouton
    @button_text = 'Cliquez-moi!'
    @text_center = 'QUI VA GAGNER ?'
  end

  def update
    if survole_bouton
        @button_color = Gosu::Color::GRAY
        if Gosu.button_down?(Gosu::MsLeft)
            @tirage = true
        end
    else
        @button_color = Gosu::Color::WHITE
    end

    if @tirage
        puts @frame % 10
        if @frame % 5 == 0
            # génère un nombre aléatoire
            # EN: if 'GO' do a draw
            utilisateur_random = rand(@tab_utilisateur.length)

            @text_center = @tab_utilisateur[utilisateur_random]
        end
        if @frame > 100
            @tirage = false
            @frame = 0
        end
        @frame+=1
    end
  end

  def draw
    # Dessine le bouton
    Gosu.draw_rect(@button_x, @button_y, @button_width, @button_height, @button_color, 1)
  
    # Dessine le texte du bouton
    button_text_width = @font.text_width(@button_text)
    button_text_x = @button_x + (@button_width - button_text_width) / 2
    button_text_y = @button_y + (@button_height - @font.height) / 2
  
    # Dessine le texte au centre de la fenêtre
    text_center_width = @font.text_width(@text_center)
    text_center_x = (800 - text_center_width*2) / 2
    text_center_y = (600 - @font.height-100) / 2
  
    @font.draw(@button_text, button_text_x, button_text_y, 10, 1, 1, Gosu::Color::BLACK)
    @font.draw(@text_center, text_center_x, text_center_y, 10, 2, 2, Gosu::Color::WHITE)
  end
  

  def survole_bouton

    x = mouse_x
    y = mouse_y

    if x > @button_x && x < @button_x + @button_width && y > @button_y && y < @button_y + @button_height
        return true
    else
        return false
    end
  end
  

  def needs_cursor?
    true
  end
end

fenetre = Fenetre.new
fenetre.show
