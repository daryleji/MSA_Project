import React from 'react';
import githubLogo from "../../assets/logos/github_logo.svg"
import { Story, Meta } from '@storybook/react';
import { SocialIconProps, SocialIcon } from './SocialIcon';

export default {
    title: 'Example/SocialIcon',
    component: SocialIcon,
} as Meta;

const Template: Story<SocialIconProps> = (args) => (
    <div style={{ backgroundColor: "black" }}>
        <SocialIcon {...args} />
    </div>
)

export const GithubIcon = Template.bind({});
GithubIcon.args = {
    name: "GitHub",
    url: "https://github.com/nzmsa",
    logo: githubLogo
};