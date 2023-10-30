import React, { useState } from 'react';
import { Container, Typography, Paper, Grid } from '@mui/material';
import { TextInput } from '@mantine/core';
import ChampionCard from './ChampionCard'; // Assuming you have a ChampionCard component

const champions = [
  // Sample data for champions
  { name: 'Ahri', title: 'The Nine-Tailed Fox', imageUrl: './src/assets/ahri.jpg' },
  // ... add more champions as needed
];

function ChampionsPage() {
  const [search, setSearch] = useState('');

  const handleSearchChange = (event: React.ChangeEvent<HTMLInputElement>) => {
    setSearch(event.target.value);
  };

  return (
    <Container>
      <Typography variant="h4" align="center" gutterBottom>
        Champions
      </Typography>
      <Paper elevation={3} style={{ padding: '20px', marginBottom: '20px' }}>
        <Grid container spacing={3} alignItems="center">
          <Grid item xs={12} md={6}>
            <TextInput placeholder="Search champions..." value={search} onChange={handleSearchChange} style={{ width: '100%' }} />
          </Grid>
        </Grid>
      </Paper>
      <Grid container spacing={3}>
        {champions.map((champion) => (
          <Grid item xs={12} sm={6} md={4} key={champion.name}>
            <ChampionCard name={champion.name} title={champion.title} imageUrl={champion.imageUrl} />
          </Grid>
        ))}
      </Grid>
    </Container>
  );
}

export default ChampionsPage;
