import React, { useState, ChangeEvent } from 'react';
import { Container, Grid, TextInput, Select } from '@mantine/core';
import ChampionCard from './ChampionCard'; // Import the ChampionCard component

const champions = [
    { name: 'Ahri', title: 'The Nine-Tailed Fox', imageUrl: './assets/ahri.jpg', description: 'Ahri is a vastaya who can reshape magic into orbs of raw energy. She revels in toying with her prey by manipulating their emotions before devouring their life essence.' },
    { name: 'Aatrox', title: 'The Darkin Blade', imageUrl: './assets/aatrox_image.jpg', description: 'Once honored defenders of Shurima against the Void, Aatrox and his brethren would eventually become an even greater threat to Runeterra.' },
];

function ChampionsPage() {
  const [search, setSearch] = useState('');
  const [sort, setSort] = useState('name');

  const filteredChampions = champions.filter(champ => champ.name.toLowerCase().includes(search.toLowerCase()));

  const sortedChampions = filteredChampions.sort((a, b) => {
    if (sort === 'name') return a.name.localeCompare(b.name);
    // Add more sorting options if needed
    return 0;
  });

  const handleSearchChange = (event: ChangeEvent<HTMLInputElement>) => {
    setSearch(event.target.value);
  };

  const handleSortChange = (value: string | null) => {
    if (value !== null) {
      setSort(value);
    }
  };

  return (
    <Container size="lg" style={{ marginTop: 40 }}>
      <div style={{ display: 'flex', justifyContent: 'space-between', marginBottom: 40 }}>
        <TextInput placeholder="Search champions..." value={search} onChange={handleSearchChange} />
        <Select data={['Name', 'Role']} value={sort} onChange={handleSortChange} />
      </div>

      <Grid gutter="md" justify="center">
        {sortedChampions.map((champion) => (
          <ChampionCard key={champion.name} name={champion.name} title={champion.title} imageUrl={champion.imageUrl} />
        ))}
      </Grid>
    </Container>
  );
}

export default ChampionsPage;
