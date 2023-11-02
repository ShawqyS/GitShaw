import { AppBar, Toolbar, Button, Typography } from '@mui/material';
import { BrowserRouter as Router, Route, Routes, Link } from 'react-router-dom';
import HomePage from './Home';
import ChampionsPage from './ChampionsPage';
import LorePage from './LorePage';
import './App.css'; // Ensure this is imported to apply your styles

function App() {
  return (
    <div style={{ display: 'flex', flexDirection: 'column', minHeight: '100vh'}}>
      <Router>
        <AppBar position="static" style={{ backgroundColor: '#1a1a1a', color: '#d4af37' }}>
          <Toolbar>
            <Typography variant="h6" style={{ flexGrow: 1 }}>
              League of Legends - Champion Guide
            </Typography>
            <Button color="inherit" component={Link} to="/" style={{ color: '#fff' }}>Home</Button>
            <Button color="inherit" component={Link} to="/champions" style={{ color: '#fff' }}>Champions</Button>
            <Button color="inherit" component={Link} to="/lore" style={{ color: '#fff' }}>Lore</Button>
          </Toolbar>
        </AppBar>
        <Routes>
          <Route path="/" element={<HomePage />} />
          <Route path="/champions" element={<ChampionsPage />} />
          <Route path="/lore" element={<LorePage />} />
        </Routes>
      </Router>
    </div>
  );
}

export default App;
