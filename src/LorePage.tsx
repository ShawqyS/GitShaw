import React, { useState } from 'react';
import { Box, Input } from '@chakra-ui/react';
import { Collapse } from 'antd';

const { Panel } = Collapse;

const lores = [
  // Sample data for lores
  { title: 'The Story of Ahri', content: 'Ahri is a vastaya who can reshape magic into orbs of raw energy...' },
  // ... add more lores as needed
];

function LorePage() {
  const [search, setSearch] = useState('');

  const handleInputChange = (event: React.ChangeEvent<HTMLInputElement>) => {
    setSearch(event.target.value);
  };

  // Apply the theme to the entire page
  const pageStyle = {
    backgroundColor: '#121212', // Dark background for the theme
    color: '#ffffff', // Text color for better readability on dark bg
    minHeight: '100vh', // Ensure it covers the full height
  };

  return (
    <div style={pageStyle}>
      <Box p={4}>
        <Input placeholder="Search lore..." value={search} onChange={handleInputChange} size="lg" style={{ backgroundColor: '#333', color: '#fff', borderColor: '#d4af37' }} />
        <Collapse style={{ marginTop: '20px', backgroundColor: '#333', borderColor: '#d4af37' }}>
          {lores.map((lore, index) => (
            <Panel header={lore.title} key={index} style={{ backgroundColor: '#333', color: '#fff' }}>
              {lore.content}
            </Panel>
          ))}
        </Collapse>
      </Box>
    </div>
  );
}

export default LorePage;
