import { AppBar, Toolbar, Button } from '@mui/material';
import { BrowserRouter as Router, Route, Routes, Link } from 'react-router-dom';
import HomePage from './Home';
import ChampionsPage from './ChampionsPage';
import LorePage from './LorePage';
import { ThemeProvider, useTheme } from './ThemeContext.js'; // Add this line

function App() {
  const { theme, toggleTheme } = useTheme(); // Add this line

  return (
    <ThemeProvider> {/* Wrap your app with ThemeProvider */}
      <div style={{ display: 'flex', flexDirection: 'column', minHeight: '100vh', backgroundColor: theme === 'dark' ? '#121212' : '#fff', color: theme === 'dark' ? '#fff' : '#000' }}> {/* Update styles for dark mode */}
        <Router>
          <AppBar position="static">
            <Toolbar>
              <Button color="inherit" component={Link} to="/">Home</Button>
              <Button color="inherit" component={Link} to="/champions">Champions</Button>
              <Button color="inherit" component={Link} to="/lore">Lore</Button>
              <Button color="inherit" onClick={toggleTheme}>Toggle Dark Mode</Button> {/* Add toggle button */}
            </Toolbar>
          </AppBar>
          <Routes>
            <Route path="/" element={<HomePage />} />
            <Route path="/champions" element={<ChampionsPage />} />
            <Route path="/lore" element={<LorePage />} />
          </Routes>
        </Router>
      </div>
    </ThemeProvider>
  );
}

export default App;
