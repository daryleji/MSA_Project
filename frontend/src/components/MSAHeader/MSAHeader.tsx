import React, { useState } from "react";
import MenuIcon from "@material-ui/icons/Menu";
import { AppBar, IconButton, Toolbar, Button, Typography, makeStyles, createStyles, Theme, Drawer} from "@material-ui/core";
import { Sidebar } from "../MSASidebar/MSASidebar"

const useStyles = makeStyles((theme: Theme) =>
  createStyles({
    root: {
      flexGrow: 1,
    },
    menuButton: {
      marginRight: theme.spacing(2),
    },
    title: {
      flexGrow: 1,
    },
    alignItemsAndJustifyContent: {
      display: 'flex',
      alignItems: 'center',
      justifyContent: 'center',
    }

  })
);

export default function MSAHeader() {
  const [sideBar, setSideBar] = useState(false);
  const classes = useStyles();

  const toggleSideBar = () => {
    setSideBar(!sideBar);
  };

  
  return (
    <div className={classes.root}>
      <AppBar position="static">
        <Toolbar>
          <IconButton
            className={classes.menuButton}
            edge="start"
            color="inherit"
            aria-label="menu"
            onClick={toggleSideBar}
          >
          <MenuIcon />
          <Drawer anchor="left" open={sideBar} onClose={toggleSideBar}>
            <Sidebar />
          </Drawer>
          </IconButton>
          <Typography className={classes.title} variant="h6">
            ReactTube
          </Typography>
          <Button color="inherit">Login</Button>
        </Toolbar>
      </AppBar>
    </div>
  );
}