import React from 'react';
import { Container, Text, Button, Paper, Image } from '@mantine/core';

function HomePage() {
  return (
    <Container size="lg" style={{ marginTop: 40 }}>
      <div style={{ textAlign: 'center', marginBottom: 50 }}>
        <Text style={{ textAlign: 'center'}} size="xxl">
          Welcome to the League of Legends Universe
        </Text>
        <Text size="xl" style={{ textAlign: 'center', marginBottom: 20 }}>
          Explore champions, lore, and the vast world of Runeterra.
        </Text>
        <Button size="lg" variant="outline">Discover More</Button>
      </div>

      <Paper style={{ marginBottom: 40 }}>
        <Text size="xl" style={{ marginBottom: 20 }}>Featured Champion: Ahri</Text>
        <Image src="./assets/ahri.jpg" alt="Ahri" style={{ width: '100%', borderRadius: 5, marginBottom: 20 }} />
        <Text>Ahri is a vastaya who can reshape magic into orbs of raw energy...</Text>
      </Paper>

      <div>
        <Text size="xl" style={{ marginBottom: 20 }}>Latest Updates</Text>
        {/* You can map through an array of news/updates and display them here */}
        <Text>- New champion release: XYZ</Text>
        <Text>- Patch 11.5 updates and changes</Text>
        <Text>- Upcoming events and tournaments</Text>
      </div>
    </Container>
  );
}

export default HomePage;
