import { Container } from '@mantine/core';
import Header from './Header';
import ChampionCard from './ChampionCard';

const champions = [
  { name: 'Ahri', title: 'The Nine-Tailed Fox', imageUrl: 'path_to_ahri_image.jpg' },
  { name: 'Aatrox', title: 'The Darkin Blade', imageUrl: 'path_to_aatrox_image.jpg' },
];

function HomePage() {
  return (
    <Container size="lg" style={{ marginTop: 40 }}>
      <Header />
      <div style={{ display: 'flex', flexWrap: 'wrap', justifyContent: 'center' }}>
        {champions.map((champion) => (
          <ChampionCard key={champion.name} {...champion} />
        ))}
      </div>
    </Container>
  );
}

export default HomePage;
