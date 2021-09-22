import { gql, useMutation } from "@apollo/client";
import { Button, FormControl, FormHelperText, Input, InputLabel } from "@material-ui/core";
import { Description, YoutubeSearchedFor } from "@material-ui/icons";
import React, { useState } from "react";

export const PROJECT = gql`
    fragment projectFields on Project {
        id
        name
        description
        link
        year
        modified
        created
    }
`;

const ADD_PROJECT = gql`
    mutation AddProject (
        $name: String!
        $description: String!
        $link: String!
        $year: String!
    ) {
        addProject(input: {name: $name, description: $description, link: $link, year: $year }) {
            ...projectFields
        }
    }
    ${PROJECT}
`;


const SubmitForm = () => {
    const [addProject] = useMutation(ADD_PROJECT);
    const [name, setName] = useState("");
    const [url, setUrl] = useState("");

    const handleNameUpdate = (event : any) => {
        setName(event.target.value);
    }

    const handleUrlUpdate = (event : any) => {
        setUrl(event.target.value);
    }

    const nameControl = <FormControl>
                <InputLabel htmlFor="my-input">Project Name</InputLabel>
                <Input id="project-input" aria-describeby="The project name" onChange={handleNameUpdate} />
                <FormHelperText id="The project name">The Github Project Name</FormHelperText>
            </FormControl>

    const urlControl = <FormControl>
                <InputLabel htmlFor="my-input">GitHub Url</InputLabel>
                <Input id="url-input" aria-describeby="The GitHub Url" onChange={handleUrlUpdate} />
                <FormHelperText id="The GitHub Url">The Github Project Url</FormHelperText>
        </FormControl>
    
    const handleSubmit = async() => {
        try {
            await addProject({variables: {
                name: name,
                description: "",
                link: url,
                year: "2021",
            }})
            } catch(e) {
                console.log(e)
            }
        };

    return <div style={{display: 'flex', flexDirection: 'column'}}>
        <div style={{display: 'flex', flexGrow: 1, alignContent: 'center', justifyContent: 'center'}}>
            {nameControl}
            {urlControl}
        </div>
        <Button onClick={handleSubmit}>Submit</Button>
    </div>
}

export default SubmitForm;