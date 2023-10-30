import React, { useState, ChangeEvent } from 'react';
import { Container, Accordion, TextInput } from '@mantine/core';

const lores = [
    { title: 'The Darkin War', content: 'The Darkin are stated to be a collection of sentient weapons by Eduard Santangelo, with Aatrox, Rhaast, and Varus being the only known remaining Darkin.' },
    { title: 'The Void', content: 'The Void is a dark and terrifying place, an abyss from which unspeakable horrors emerge to destroy the very fabric of the universe.' },
];

function LorePage() {
  const [search, setSearch] = useState('');

  const filteredLores = lores.filter(lore => lore.title.toLowerCase().includes(search.toLowerCase()));
  const [openItem, setOpenItem] = useState<string | null>(null);

  const handleInputChange = (event: ChangeEvent<HTMLInputElement>) => {
    setSearch(event.target.value);
  };

  const handleAccordionChange = (value: string | null) => {
    // Handle accordion item changes here
    setOpenItem(value);
  };

  return (
    <Container size="lg" style={{ marginTop: 40 }}>
      <div style={{ marginBottom: 40 }}>
        <TextInput placeholder="Search lore..." value={search} onChange={handleInputChange} />
      </div>

      <Accordion value={openItem} onChange={handleAccordionChange}>
        {filteredLores.map((lore, index) => (
          <Accordion.Item title={lore.title} key={index} value={lore.title}>
            {lore.content}
          </Accordion.Item>
        ))}
      </Accordion>
    </Container>
  );
}

export default LorePage;
