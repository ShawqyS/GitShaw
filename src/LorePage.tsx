import { useState } from 'react';
import { Container, Text, Accordion } from '@mantine/core';
import Header from './Header';

const lores = [
  { title: 'The Darkin War', content: 'The Darkin are stated to be a collection of sentient weapons by Eduard Santangelo, with Aatrox, Rhaast, and Varus being the only known remaining Darkin.' },
  { title: 'The Void', content: 'The Void is a dark and terrifying place, an abyss from which unspeakable horrors emerge to destroy the very fabric of the universe.' },
  // ... add more lore as needed
];

function LorePage() {
  const [openItem, setOpenItem] = useState<string | null>(null);

  const handleAccordionChange = (value: string | null) => {
    // Handle accordion item changes here
    setOpenItem(value);
  };

  return (
    <Container size="lg" style={{ marginTop: 40 }}>
      <Header />
      <Text size="xxl" style={{ textAlign: 'center', marginBottom: 20 }}>
        League of Legends Lore
      </Text>
      <Accordion value={openItem} onChange={handleAccordionChange}>
        {lores.map((lore, index) => (
          <Accordion.Item title={lore.title} key={index} value={lore.title}>
            {lore.content}
          </Accordion.Item>
        ))}
      </Accordion>
    </Container>
  );
}

export default LorePage;
