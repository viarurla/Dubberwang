import {Box, HStack, List, ListItem} from "@chakra-ui/react";
import LotteryBall from "./LotteryBall";

// When supplied an array of LotteryBalls, it then populates a horizontal bar.
// This is to simulate real lottery drawing formats.
const LotteryBallDock = (props) => {
    return (
        <Box>
            <HStack>
                <List display={"flex"} flexDir={"row"} alignItems={"center"}>
                    {props.balls.map((ball, index) =>
                        <ListItem key={index} margin={"5px"}>
                            {/* Bonus balls get a fancy golden border! */}
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