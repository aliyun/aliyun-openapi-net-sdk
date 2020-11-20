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
    public class BodyPostureResponseUnmarshaller
    {
        public static BodyPostureResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BodyPostureResponse bodyPostureResponse = new BodyPostureResponse();

			bodyPostureResponse.HttpResponse = _ctx.HttpResponse;
			bodyPostureResponse.RequestId = _ctx.StringValue("BodyPosture.RequestId");

			BodyPostureResponse.BodyPosture_Data data = new BodyPostureResponse.BodyPosture_Data();

			BodyPostureResponse.BodyPosture_Data.BodyPosture_MetaObject metaObject = new BodyPostureResponse.BodyPosture_Data.BodyPosture_MetaObject();
			metaObject.Height = _ctx.IntegerValue("BodyPosture.Data.MetaObject.Height");
			metaObject.Width = _ctx.IntegerValue("BodyPosture.Data.MetaObject.Width");
			data.MetaObject = metaObject;

			List<BodyPostureResponse.BodyPosture_Data.BodyPosture_Output> data_outputs = new List<BodyPostureResponse.BodyPosture_Data.BodyPosture_Output>();
			for (int i = 0; i < _ctx.Length("BodyPosture.Data.Outputs.Length"); i++) {
				BodyPostureResponse.BodyPosture_Data.BodyPosture_Output output = new BodyPostureResponse.BodyPosture_Data.BodyPosture_Output();
				output.HumanCount = _ctx.IntegerValue("BodyPosture.Data.Outputs["+ i +"].HumanCount");

				List<BodyPostureResponse.BodyPosture_Data.BodyPosture_Output.BodyPosture_Result> output_results = new List<BodyPostureResponse.BodyPosture_Data.BodyPosture_Output.BodyPosture_Result>();
				for (int j = 0; j < _ctx.Length("BodyPosture.Data.Outputs["+ i +"].Results.Length"); j++) {
					BodyPostureResponse.BodyPosture_Data.BodyPosture_Output.BodyPosture_Result result = new BodyPostureResponse.BodyPosture_Data.BodyPosture_Output.BodyPosture_Result();

					List<BodyPostureResponse.BodyPosture_Data.BodyPosture_Output.BodyPosture_Result.BodyPosture_Body> result_bodies = new List<BodyPostureResponse.BodyPosture_Data.BodyPosture_Output.BodyPosture_Result.BodyPosture_Body>();
					for (int k = 0; k < _ctx.Length("BodyPosture.Data.Outputs["+ i +"].Results["+ j +"].Bodies.Length"); k++) {
						BodyPostureResponse.BodyPosture_Data.BodyPosture_Output.BodyPosture_Result.BodyPosture_Body body = new BodyPostureResponse.BodyPosture_Data.BodyPosture_Output.BodyPosture_Result.BodyPosture_Body();
						body.Confident = _ctx.FloatValue("BodyPosture.Data.Outputs["+ i +"].Results["+ j +"].Bodies["+ k +"].Confident");
						body.Label = _ctx.StringValue("BodyPosture.Data.Outputs["+ i +"].Results["+ j +"].Bodies["+ k +"].Label");

						List<BodyPostureResponse.BodyPosture_Data.BodyPosture_Output.BodyPosture_Result.BodyPosture_Body.BodyPosture_Position> body_positions = new List<BodyPostureResponse.BodyPosture_Data.BodyPosture_Output.BodyPosture_Result.BodyPosture_Body.BodyPosture_Position>();
						for (int l = 0; l < _ctx.Length("BodyPosture.Data.Outputs["+ i +"].Results["+ j +"].Bodies["+ k +"].Positions.Length"); l++) {
							BodyPostureResponse.BodyPosture_Data.BodyPosture_Output.BodyPosture_Result.BodyPosture_Body.BodyPosture_Position position = new BodyPostureResponse.BodyPosture_Data.BodyPosture_Output.BodyPosture_Result.BodyPosture_Body.BodyPosture_Position();

							List<string> position_points = new List<string>();
							for (int m = 0; m < _ctx.Length("BodyPosture.Data.Outputs["+ i +"].Results["+ j +"].Bodies["+ k +"].Positions["+ l +"].Points.Length"); m++) {
								position_points.Add(_ctx.StringValue("BodyPosture.Data.Outputs["+ i +"].Results["+ j +"].Bodies["+ k +"].Positions["+ l +"].Points["+ m +"]"));
							}
							position.Points = position_points;

							body_positions.Add(position);
						}
						body.Positions = body_positions;

						result_bodies.Add(body);
					}
					result.Bodies = result_bodies;

					output_results.Add(result);
				}
				output.Results = output_results;

				data_outputs.Add(output);
			}
			data.Outputs = data_outputs;
			bodyPostureResponse.Data = data;
        
			return bodyPostureResponse;
        }
    }
}
