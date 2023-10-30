import { Container, Text, Card } from '@mantine/core';
import Header from './Header';

const champions = [
  { name: 'Ahri', title: 'The Nine-Tailed Fox', imageUrl: './assets/ahri_image.jpg', description: 'Ahri is a vastaya who can reshape magic into orbs of raw energy. She revels in toying with her prey by manipulating their emotions before devouring their life essence.' },
  { name: 'Aatrox', title: 'The Darkin Blade', imageUrl: './assets/aatrox_image.jpg', description: 'Once honored defenders of Shurima against the Void, Aatrox and his brethren would eventually become an even greater threat to Runeterra.' },
  // ... add more champions as needed
];

function ChampionsPage() {
  return (
    <Container size="lg" style={{ marginTop: 40 }}>
      <Header />
      <div style={{ display: 'flex', flexWrap: 'wrap', justifyContent: 'center' }}>
        {champions.map((champion) => (
          <Card key={champion.name} style={{ width: 250, margin: 10 }}>
            <img src={champion.imageUrl} alt={champion.name} style={{ width: '100%' }} />
            <Text size="xl" style={{ textAlign: 'center', marginTop: 10}}>
              {champion.name}
            </Text>
            <Text size="sm" style={{ textAlign: 'center', marginTop: 5}}>
              {champion.title}
            </Text>
            <Text size="xs" style={{ marginTop: 10, padding: 10 }}>
              {champion.description}
            </Text>
          </Card>
        ))}
      </div>
    </Container>
  );
}

export default ChampionsPage;
