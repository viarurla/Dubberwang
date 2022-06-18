import {Box, HStack, List, ListItem} from "@chakra-ui/react";
import LotteryBall from "./LotteryBall";


const LotteryBallDock = (props) => {

    return (
        <Box>
            <HStack>
                <List display={"flex"} flexDir={"row"} alignItems={"center"}>
                    {props.balls.map((ball, index) =>
                        <ListItem key={index} margin={"5px"}>
                            {ball.isBonus
                                ?   <Box borderColor={"gold"} borderWidth={"5px"} borderRadius={"30px"}>
                                        <LotteryBall ball ={ball}/>
                                    </Box>
                                : <LotteryBall ball={ball}/>
                            }
                        </ListItem>
                    )}
                </List>
            </HStack>
        </Box>
    )
}

export default LotteryBallDock;