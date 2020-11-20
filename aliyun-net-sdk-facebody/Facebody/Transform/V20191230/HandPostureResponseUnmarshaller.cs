/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.facebody.Model.V20191230;

namespace Aliyun.Acs.facebody.Transform.V20191230
{
    public class HandPostureResponseUnmarshaller
    {
        public static HandPostureResponse Unmarshall(UnmarshallerContext _ctx)
        {
			HandPostureResponse handPostureResponse = new HandPostureResponse();

			handPostureResponse.HttpResponse = _ctx.HttpResponse;
			handPostureResponse.RequestId = _ctx.StringValue("HandPosture.RequestId");

			HandPostureResponse.HandPosture_Data data = new HandPostureResponse.HandPosture_Data();

			HandPostureResponse.HandPosture_Data.HandPosture_MetaObject metaObject = new HandPostureResponse.HandPosture_Data.HandPosture_MetaObject();
			metaObject.Height = _ctx.IntegerValue("HandPosture.Data.MetaObject.Height");
			metaObject.Width = _ctx.IntegerValue("HandPosture.Data.MetaObject.Width");
			data.MetaObject = metaObject;

			List<HandPostureResponse.HandPosture_Data.HandPosture_Output> data_outputs = new List<HandPostureResponse.HandPosture_Data.HandPosture_Output>();
			for (int i = 0; i < _ctx.Length("HandPosture.Data.Outputs.Length"); i++) {
				HandPostureResponse.HandPosture_Data.HandPosture_Output output = new HandPostureResponse.HandPosture_Data.HandPosture_Output();
				output.HandCount = _ctx.IntegerValue("HandPosture.Data.Outputs["+ i +"].HandCount");

				List<HandPostureResponse.HandPosture_Data.HandPosture_Output.HandPosture_Result> output_results = new List<HandPostureResponse.HandPosture_Data.HandPosture_Output.HandPosture_Result>();
				for (int j = 0; j < _ctx.Length("HandPosture.Data.Outputs["+ i +"].Results.Length"); j++) {
					HandPostureResponse.HandPosture_Data.HandPosture_Output.HandPosture_Result result = new HandPostureResponse.HandPosture_Data.HandPosture_Output.HandPosture_Result();

					HandPostureResponse.HandPosture_Data.HandPosture_Output.HandPosture_Result.HandPosture_Box box = new HandPostureResponse.HandPosture_Data.HandPosture_Output.HandPosture_Result.HandPosture_Box();
					box.Confident = _ctx.FloatValue("HandPosture.Data.Outputs["+ i +"].Results["+ j +"].Box.Confident");

					List<HandPostureResponse.HandPosture_Data.HandPosture_Output.HandPosture_Result.HandPosture_Box.HandPosture_Position> box_positions = new List<HandPostureResponse.HandPosture_Data.HandPosture_Output.HandPosture_Result.HandPosture_Box.HandPosture_Position>();
					for (int k = 0; k < _ctx.Length("HandPosture.Data.Outputs["+ i +"].Results["+ j +"].Box.Positions.Length"); k++) {
						HandPostureResponse.HandPosture_Data.HandPosture_Output.HandPosture_Result.HandPosture_Box.HandPosture_Position position = new HandPostureResponse.HandPosture_Data.HandPosture_Output.HandPosture_Result.HandPosture_Box.HandPosture_Position();

						List<string> position_points = new List<string>();
						for (int l = 0; l < _ctx.Length("HandPosture.Data.Outputs["+ i +"].Results["+ j +"].Box.Positions["+ k +"].Points.Length"); l++) {
							position_points.Add(_ctx.StringValue("HandPosture.Data.Outputs["+ i +"].Results["+ j +"].Box.Positions["+ k +"].Points["+ l +"]"));
						}
						position.Points = position_points;

						box_positions.Add(position);
					}
					box.Positions = box_positions;
					result.Box = box;

					HandPostureResponse.HandPosture_Data.HandPosture_Output.HandPosture_Result.HandPosture_Hands hands = new HandPostureResponse.HandPosture_Data.HandPosture_Output.HandPosture_Result.HandPosture_Hands();
					hands.Confident = _ctx.FloatValue("HandPosture.Data.Outputs["+ i +"].Results["+ j +"].Hands.Confident");

					List<HandPostureResponse.HandPosture_Data.HandPosture_Output.HandPosture_Result.HandPosture_Hands.HandPosture_KeyPoint> hands_keyPoints = new List<HandPostureResponse.HandPosture_Data.HandPosture_Output.HandPosture_Result.HandPosture_Hands.HandPosture_KeyPoint>();
					for (int k = 0; k < _ctx.Length("HandPosture.Data.Outputs["+ i +"].Results["+ j +"].Hands.KeyPoints.Length"); k++) {
						HandPostureResponse.HandPosture_Data.HandPosture_Output.HandPosture_Result.HandPosture_Hands.HandPosture_KeyPoint keyPoint = new HandPostureResponse.HandPosture_Data.HandPosture_Output.HandPosture_Result.HandPosture_Hands.HandPosture_KeyPoint();
						keyPoint.Label = _ctx.StringValue("HandPosture.Data.Outputs["+ i +"].Results["+ j +"].Hands.KeyPoints["+ k +"].Label");

						List<HandPostureResponse.HandPosture_Data.HandPosture_Output.HandPosture_Result.HandPosture_Hands.HandPosture_KeyPoint.HandPosture_Position2> keyPoint_positions1 = new List<HandPostureResponse.HandPosture_Data.HandPosture_Output.HandPosture_Result.HandPosture_Hands.HandPosture_KeyPoint.HandPosture_Position2>();
						for (int l = 0; l < _ctx.Length("HandPosture.Data.Outputs["+ i +"].Results["+ j +"].Hands.KeyPoints["+ k +"].Positions.Length"); l++) {
							HandPostureResponse.HandPosture_Data.HandPosture_Output.HandPosture_Result.HandPosture_Hands.HandPosture_KeyPoint.HandPosture_Position2 position2 = new HandPostureResponse.HandPosture_Data.HandPosture_Output.HandPosture_Result.HandPosture_Hands.HandPosture_KeyPoint.HandPosture_Position2();

							List<string> position2_points3 = new List<string>();
							for (int m = 0; m < _ctx.Length("HandPosture.Data.Outputs["+ i +"].Results["+ j +"].Hands.KeyPoints["+ k +"].Positions["+ l +"].Points.Length"); m++) {
								position2_points3.Add(_ctx.StringValue("HandPosture.Data.Outputs["+ i +"].Results["+ j +"].Hands.KeyPoints["+ k +"].Positions["+ l +"].Points["+ m +"]"));
							}
							position2.Points3 = position2_points3;

							keyPoint_positions1.Add(position2);
						}
						keyPoint.Positions1 = keyPoint_positions1;

						hands_keyPoints.Add(keyPoint);
					}
					hands.KeyPoints = hands_keyPoints;
					result.Hands = hands;

					output_results.Add(result);
				}
				output.Results = output_results;

				data_outputs.Add(output);
			}
			data.Outputs = data_outputs;
			handPostureResponse.Data = data;
        
			return handPostureResponse;
        }
    }
}
