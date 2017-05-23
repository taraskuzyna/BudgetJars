import React, { Component } from 'react';
import { Table, TableBody, TableHeader, TableRow, TableRowColumn, TableHeaderColumn } from 'material-ui'
import MuiThemeProvider from 'material-ui/styles/MuiThemeProvider'

class JarOverview extends Component {
    render() {
        return (
            <MuiThemeProvider>
                <Table>
                    <TableHeader>
                        <TableHeaderColumn>
                            col 1
                    </TableHeaderColumn>
                        <TableHeaderColumn>
                            col 2
                    </TableHeaderColumn>
                        <TableHeaderColumn>
                            col 3
                    </TableHeaderColumn>
                    </TableHeader>
                    <TableBody>
                        <TableRow>
                            <TableRowColumn>
                                val 1
                        </TableRowColumn>
                            <TableRowColumn>
                                val 1
                        </TableRowColumn>
                            <TableRowColumn>
                                val 1
                        </TableRowColumn>
                        </TableRow>
                        <TableRow>
                            <TableRowColumn>
                                val 1
                        </TableRowColumn>
                            <TableRowColumn>
                                val 1
                        </TableRowColumn>
                            <TableRowColumn>
                                val 1
                        </TableRowColumn>
                        </TableRow>
                    </TableBody>
                </Table>
            </MuiThemeProvider>
        );
    }
}

export default JarOverview;
