import { AppBar, Toolbar, Button } from '@mui/material';
import { BrowserRouter as Router, Route, Routes, Link } from 'react-router-dom';
import HomePage from './Home';
import ChampionsPage from './ChampionsPage';
import LorePage from './LorePage';

function App() {
  return (
    <div style={{ display: 'flex', flexDirection: 'column', minHeight: '100vh' }}>
      <Router>
      <AppBar position="static">
        <Toolbar>
          <Button color="inherit" component={Link} to="/">Home</Button>
          <Button color="inherit" component={Link} to="/champions">Champions</Button>
          <Button color="inherit" component={Link} to="/lore">Lore</Button>
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
