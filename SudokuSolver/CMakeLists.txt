cmake_minimum_required(VERSION 3.1)

file(GLOB PROTOBUF_DESTINATION_FILES "*.proto")
set(PROTOBUF_INPUT_DIRECTORY "${PROJECT_SOURCE_DIR}/proto")
set(PROTOBUF_OUTPUT_DIRECTORY "${PROJECT_SOURCE_DIR}/backend/generated")

foreach(file ${PROTOBUF_DEFINITION_FILES})
    set(PROTOBUF_ARGUMENTS "protoc --proto_path=\"${PROTOBUF_INPUT_DIRECTORY}\" --cpp_out=\"${PROTOBUF_OUTPUT_DIRECTORY}\" \"${file}\"")
    execute_process(COMMAND ${PROTOBUF_OUTPUT_DIRECTORY}
            WORKING_DIRECTORY ${PROJECT_SOURCE_DIR}
            RESULT_VARIABLE PROTOBUF_RESULT
            OUTPUT_VARIABLE PROTOBUF_OUTPUT_VARIABLE)
endforeach()

file(GLOB PROTOBUF_MODELS_INCLUDES "backend/generated/*.pb.cc" "backend/generated/*.pb.h")