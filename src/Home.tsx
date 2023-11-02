import { Container, Typography, Paper, Grid, CardMedia } from '@mui/material';
import { Button } from 'antd';
import LatestNewsCard from './Newscard';

function HomePage() {
  const newsItems = [
    {
      title: "New Champion Release: Aether, the Skyblade",
      description: "Aether, the Skyblade, soars into the Rift! With her ethereal wings and swift attacks, she's set to redefine the skies of Summoner's Rift.",
      imageUrl: "/images/aether_release.jpg" // Replace with the actual path to your news images
    },
    {
      title: "Preseason Update: Vision Rework",
      description: "The upcoming preseason is bringing a major rework to vision in the game. Dive into the full update notes to learn more.",
      imageUrl: "/images/vision_rework.jpg"
    },
    {
      title: "Worlds 2023: The Battle for the Cup Continues",
      description: "The quarterfinals are up next with teams from around the globe competing for the Summoner's Cup. Check out the schedule!",
      imageUrl: "/images/worlds_quarterfinals.jpg"
    },
    {
      title: "Patch 11.24 Highlights: Balancing the Battlefield",
      description: "Patch 11.24 is live with targeted balance changes to champions and items. Read the full patch breakdown for all the details.",
      imageUrl: "/images/patch_11_24.jpg"
    }
  ];
  return (
    
    <Container style={{ display: 'flex', flexDirection: 'column', minHeight: '100vh' }}>
      <Typography variant="h2" align="center" gutterBottom>
        Welcome to the League of Legends Universe
      </Typography>
      <Typography variant="h5" align="center" gutterBottom>
        Explore champions, lore, and the vast world of Runeterra.
      </Typography>

      {/* Featured Champion */}
      <Paper elevation={3} style={{ padding: '20px', margin: '40px 0' }}>
        <Grid container spacing={3}>
          <Grid item xs={12} md={4}>
            <CardMedia
              component="img"
              image="./src/assets/ahri.jpg" // Replace with the actual path or URL to Ahri's image
              alt="Ahri"
            />
          </Grid>
          <Grid item xs={12} md={8}>
            <Typography variant="h6">Ahri - The Nine-Tailed Fox</Typography>
            <Typography variant="body1" paragraph>
              Amidst the mists and coldest frosts, with barest wrists and stoutest boasts, she thrusts her fists against the posts...
              {/* Add Ahri's lore here */}
            </Typography>
            <Button type="primary">Learn More</Button>
          </Grid>
        </Grid>
      </Paper>

      {/* Latest News */}
      <Typography variant="h4" align="center" gutterBottom>
        Latest News
      </Typography>
      <Grid container spacing={3}>
        {newsItems.map((newsItem, index) => (
          <Grid item xs={12} sm={6} md={3} key={index}>
            <LatestNewsCard
              title={newsItem.title}
              description={newsItem.description}
              imageUrl={newsItem.imageUrl}
            />
          </Grid>
        ))}
      </Grid>

      {/* Join the Battle */}
      <Paper elevation={3} style={{ padding: '40px', margin: '40px 0', textAlign: 'center' }}>
        <Typography variant="h4" gutterBottom>
          Ready to Join the Battle?
        </Typography>
        <Typography variant="h6" paragraph>
          Dive into the world of Runeterra and experience epic battles, intriguing stories, and much more.
        </Typography>
        <Button type="primary" size="large">Play Now</Button>
      </Paper>
    </Container>
  );
}

export default HomePage;
