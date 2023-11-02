import React, { useState } from 'react';
import { Box, Input, useColorModeValue } from '@chakra-ui/react';
import { Collapse } from 'antd';
import './App.css'; // Make sure to import App.css

const { Panel } = Collapse;

const lores = [
  { title: 'The Story of Ahri', content: 'Ahri is a vastaya who can reshape magic into orbs of raw energy. She revels in toying with her prey by manipulating their emotions before devouring their life essence. Amidst the mists and coldest frosts, she found the way to be free from her past.' },
  { title: 'The Tale of Akali', content: 'Akali is a rogue assassin who strikes from the shadows. She has renounced her clan’s traditional teachings to follow her own path—the way of the deadly kama, striking in silence and escaping without trace.' },
  { title: 'The Legend of Alistar', content: 'Once a mighty warrior from the Minotaur tribes, Alistar was captured and forced into the life of a gladiator. Now, he fights for freedom and justice, a symbol of the strength of will and body.' },
  { title: 'The Curse of Amumu', content: 'Amumu is a lonely and melancholic creature, cursed to roam the deserts, seeking the solace of a friend and the end of his ancient curse. His touch is death, his friendship a curse.' },
  { title: 'The Saga of Anivia', content: 'Anivia is a benevolent winged spirit who endures endless cycles of life, death, and rebirth to protect the Freljord. She is an immortal being of ice and snow, friend to all those who respect the harsh lands.' },
  { title: 'The Darkness of Annie', content: 'Annie is a child mage with immense pyrokinetic power. She wanders the dark forests of Noxus, where she is drawn to its wild, untamed magic and the chaos it brings to all those who dare to wield it.' },
  { title: 'The Frost Archer, Ashe', content: 'Ashe is a master archer and born leader. In the cold mountains of Freljord, she works to unite its people, wielding her ancestral bow of true ice against those who would oppose her.' },
  { title: 'Aurelion Sol, The Star Forger', content: 'Aurelion Sol once graced the vast emptiness of the cosmos with celestial wonders of his own devising. Now, he is forced to wield his awesome power at the behest of a space-faring empire, which tricked him into servitude.' },
  { title: 'Azir, The Emperor of the Sands', content: 'Azir was a mortal emperor of Shurima who was betrayed and his empire fell to ruin. Resurrected centuries later, he seeks to restore his lost glory and bring a new era of prosperity to his people.' },
  { title: 'The Wandering Caretaker, Bard', content: 'Bard travels through realms beyond the imagination of mortal beings. Some of Runeterra’s most significant artifacts are the caretaker’s responsibility, and he goes wherever the call of destiny takes him.' },
  { title: 'The Great Steam Golem, Blitzcrank', content: 'Blitzcrank was created to dispose of hazardous waste, but he found a higher calling as a hero who protects the citizens of Zaun with his strength and determination, proving that a heart of gold can come from anywhere.' },
  { title: 'Brand, The Burning Vengeance', content: 'Brand is a vengeful spirit of fire, once a tribesman of the icy Freljord, who was consumed by his own inner flame. Now, he is a creature of pure fire, seeking to incinerate everything in his path.' },
  { title: 'Braum, The Heart of the Freljord', content: 'Braum is a hero beloved by the Freljordian people. He carries a door from a mountain vault as his shield, using it to protect the innocent and to bash his way through the ills that plague his homeland.' },
  { title: 'Caitlyn, The Sheriff of Piltover', content: 'Caitlyn is Piltover’s best shot at ridding the city of its elusive criminals. She is known for her sharp wit and sharper sight, and she never misses her target.' },
  { title: 'Camille, The Steel Shadow', content: 'Camille is the principal intelligencer of the Ferros clan, tasked with enforcing the Piltover standard of techmaturgy and eliminating any threats to her family’s superiority with precision and decisiveness.' },
  { title: 'Cassiopeia, The Serpent’s Embrace', content: 'Cassiopeia is a deadly creature bent on manipulation and power. Her victims suffer from venom and betrayal, often seeing their demise before they realize her true nature.' },
  { title: 'Cho’Gath, The Terror of the Void', content: 'Cho’Gath is a creature from the Void, a place of absolute darkness and terror. He grows larger and more powerful with each life he consumes, and he hungers for the day he can swallow the world.' },
  { title: 'Corki, The Daring Bombardier', content: 'Corki, with his daring aerial maneuvers, strikes fear into the hearts of those who oppose him. His flying machine is always bristling with powerful weapons and bombs.' },
];

function LorePage() {
  const [search, setSearch] = useState('');

  const handleInputChange = (event: React.ChangeEvent<HTMLInputElement>) => {
    setSearch(event.target.value);
  };

  const filteredLores = lores.filter(lore =>
    lore.title.toLowerCase().includes(search.toLowerCase())
  );

  const bg = useColorModeValue('white', 'gray.800');
  const color = useColorModeValue('gray.800', 'white');

  return (
    <div className="lore-page">
      <Box className="search-box">
        <Input
          className="search-input"
          placeholder="Search lore..."
          value={search}
          onChange={handleInputChange}
        />
      </Box>
      <Collapse className="lore-collapse" bordered={false} defaultActiveKey={['0']}>
        {filteredLores.map((lore, index) => (
          <Panel header={lore.title} key={index} className="lore-panel" style={{ backgroundColor: bg, color }}>
            <p>{lore.content}</p>
          </Panel>
        ))}
      </Collapse>
    </div>
  );
}

export default LorePage;
