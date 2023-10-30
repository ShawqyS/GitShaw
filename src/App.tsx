import { BrowserRouter as Router, Route, Routes, Link } from 'react-router-dom';
import HomePage from './Home';
import ChampionsPage from './ChampionsPage';
import LorePage from './LorePage';
import { Container } from '@mantine/core';

function App() {
  return (
    <Router>
      <Container size="lg" style={{ marginTop: 40 }}>
        <nav>
          <Link to="/">Home</Link>
          <Link to="/champions" style={{ marginLeft: 20 }}>Champions</Link>
          <Link to="/lore" style={{ marginLeft: 20 }}>Lore</Link>
        </nav>
        <Routes>
          <Route path="/" element={<HomePage />} />
          <Route path="/champions" element={<ChampionsPage />} />
          <Route path="/lore" element={<LorePage />} />
        </Routes>
      </Container>
    </Router>
  );
}

export default App;
