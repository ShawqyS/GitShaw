import React, { useState } from 'react';
import { Container, Grid } from '@mui/material';
import { TextInput } from '@mantine/core';
import Slider, { Settings } from 'react-slick';
import 'slick-carousel/slick/slick.css';
import 'slick-carousel/slick/slick-theme.css';
import ChampionCard from './ChampionCard'; 

const champions = [
  { name: 'Ahri', title: 'The Nine-Tailed Fox', imageUrl: './src/assets/ahri.jpg' },
  { name: 'Akali', title: 'The Rogue Assassin', imageUrl: './src/assets/akali.jpg' },
  { name: 'Alistar', title: 'The Minotaur', imageUrl: './src/assets/alistar.jpg' },
  { name: 'Amumu', title: 'The Sad Mummy', imageUrl: './src/assets/amumu.jpg' },
  { name: 'Anivia', title: 'The Cryophoenix', imageUrl: './src/assets/anivia.jpg' },
  { name: 'Annie', title: 'The Dark Child', imageUrl: './src/assets/annie.jpg' },
  { name: 'Ashe', title: 'The Frost Archer', imageUrl: './src/assets/ashe.jpg' },
  { name: 'Aurelion Sol', title: 'The Star Forger', imageUrl: './src/assets/aurelionsol.jpg' },
  { name: 'Azir', title: 'The Emperor of the Sands', imageUrl: './src/assets/azir.jpg' },
  { name: 'Bard', title: 'The Wandering Caretaker', imageUrl: './src/assets/bard.jpg' },
  { name: 'Blitzcrank', title: 'The Great Steam Golem', imageUrl: './src/assets/blitzcrank.jpg' },
  { name: 'Brand', title: 'The Burning Vengeance', imageUrl: './src/assets/brand.jpg' },
  { name: 'Braum', title: 'The Heart of the Freljord', imageUrl: './src/assets/braum.jpg' },
  { name: 'Caitlyn', title: 'The Sheriff of Piltover', imageUrl: './src/assets/caitlyn.jpg' },
  { name: 'Camille', title: 'The Steel Shadow', imageUrl: './src/assets/camille.jpg' },
  { name: 'Cassiopeia', title: 'The Serpent’s Embrace', imageUrl: './src/assets/cassiopeia.jpg' },
  { name: 'Cho’Gath', title: 'The Terror of the Void', imageUrl: './src/assets/cho.jpg' },
  { name: 'Corki', title: 'The Daring Bombardier', imageUrl: './src/assets/gorki.jpg' },
];

function ChampionsPage() {
  const [search, setSearch] = useState('');

  const handleSearchChange = (event: React.ChangeEvent<HTMLInputElement>) => {
    setSearch(event.target.value);
  };

  const filteredChampions = champions.filter(champion =>
    champion.name.toLowerCase().includes(search.toLowerCase())
  );

  // Settings for the slider
  const settings: Settings = {
    dots: true,
    infinite: true,
    speed: 500,
    slidesToShow: 1,
    slidesToScroll: 1,
    autoplay: true,
    autoplaySpeed: 2000,
    cssEase: "linear",
    centerMode: true,
    appendDots: dots => (
      <div style={{ position: 'absolute', bottom: '10px', width: '100%' }}>
        <ul style={{ margin: '0px' }}> {dots} </ul>
      </div>
    ),
  };

  return (
    <div className="page-style">
      <Container maxWidth="md">
        <div className="carousel-container">
          <Slider {...settings}>
            {champions.map((champion, index) => (
              <div key={index} className="carousel-slide">
                <div className="carousel-title">Champions</div> {/* Title on every slide */}
                <img src={champion.imageUrl} alt={champion.name} className="carousel-image" />
              </div>
            ))}
          </Slider>
        </div>
        <div className="search-container">
          <TextInput
            placeholder="Search champions..."
            value={search}
            onChange={handleSearchChange}
            className="search-input"
          />
        </div>
        <Grid container spacing={3}>
          {filteredChampions.map((champion) => (
            <Grid item xs={12} sm={6} md={4} key={champion.name}>
              <ChampionCard name={champion.name} title={champion.title} imageUrl={champion.imageUrl} />
            </Grid>
          ))}
        </Grid>
      </Container>
    </div>
  );
}

export default ChampionsPage;