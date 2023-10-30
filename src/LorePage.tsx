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

  return (
    <Box p={4}>
      <Input placeholder="Search lore..." value={search} onChange={handleInputChange} size="lg" />
      <Collapse style={{ marginTop: '20px' }}>
        {lores.map((lore, index) => (
          <Panel header={lore.title} key={index}>
            {lore.content}
          </Panel>
        ))}
      </Collapse>
    </Box>
  );
}

export default LorePage;
