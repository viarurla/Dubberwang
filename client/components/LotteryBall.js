import {Box, Text} from "@chakra-ui/react";


const LotteryBall = (props) => {

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