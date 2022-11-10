import React from 'react'
import { Button, Card, CardContent, TextField, Typography } from '@mui/material'
import { Box } from '@mui/system'
import Center from './Center'

export default function Registration() {
    return (
        <Center>
            <Card sx={{ width: 400 }}>
                <CardContent sx={{ textAlign: 'center' }}>
                    <Typography variant="h3" sx={{ my: 3 }}>Register</Typography>
                    <Box sx={{
                        '& .MuiTextField-root':
                        {
                            margin: 1,
                            width: '90%'
                        }
                    }}>
                        <form noValidate autoComplete='off'>
                            <TextField
                                label="Username"
                                name="Username"
                                variant="outlined" />
                            <TextField
                                label="Password"
                                name="Password"
                                variant="outlined" />
                            <TextField
                                label="FirstName"
                                name="FirstName"
                                variant="outlined" />
                            <TextField
                                label="LastName"
                                name="LastName"
                                variant="outlined" />
                            <TextField
                                label="Email"
                                name="Email"
                                variant="outlined" />
                            <TextField
                                label="Role"
                                name="Role"
                                variant="outlined" />
                            <Button
                                type="submit"
                                variant="contained"
                                size="medium"
                                sx={{ width: "90%" }}>Register</Button>

                        </form>
                    </Box>
                </CardContent>
            </Card>
        </Center>


    )
}
