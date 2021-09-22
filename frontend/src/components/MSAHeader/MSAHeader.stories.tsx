import React from 'react';
import { ComponentStory, ComponentMeta } from '@storybook/react';
import MSAHeader from './MSAHeader';


export default {
  title: 'UI Components/MSAHeader',
  component: MSAHeader,
} as ComponentMeta<typeof MSAHeader>;

const Template: ComponentStory<typeof MSAHeader> = () => <MSAHeader />;

export const BasicHeader = Template.bind({});