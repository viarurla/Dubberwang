import {Box, Text} from "@chakra-ui/react";

// Component that displays the core properties of the LotteryBall
const LotteryBall = (props) => {
    
    // To ensure uniform form, we check for the length and preprend a 0 to it
    // This is not what I'd do in an ideal scenario, but it's a fun cheat for now.
    const formatBallText = () => {
        let value = props.ball.value.toString();
        if (value.length === 1) {
            return `0${value}`;
        }
        return value;
    }

    return (
        <Box borderColor={props.ball["hexColor"]} padding={"10px"} borderRadius={"25px"} borderWidth={"10px"}>
            <Text fontWeight={"bold"}>
                {formatBallText()}
            </Text>
        </Box>
    )
}

export default LotteryBall;