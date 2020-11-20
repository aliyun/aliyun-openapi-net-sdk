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
using Aliyun.Acs.objectdet.Model.V20191230;

namespace Aliyun.Acs.objectdet.Transform.V20191230
{
    public class DetectVehicleResponseUnmarshaller
    {
        public static DetectVehicleResponse Unmarshall(UnmarshallerContext context)
        {
			DetectVehicleResponse detectVehicleResponse = new DetectVehicleResponse();

			detectVehicleResponse.HttpResponse = context.HttpResponse;
			detectVehicleResponse.RequestId = context.StringValue("DetectVehicle.RequestId");

			DetectVehicleResponse.DetectVehicle_Data data = new DetectVehicleResponse.DetectVehicle_Data();
			data.Width = context.IntegerValue("DetectVehicle.Data.Width");
			data.Height = context.IntegerValue("DetectVehicle.Data.Height");

			List<DetectVehicleResponse.DetectVehicle_Data.DetectVehicle_DetectObjectInfo> data_detectObjectInfoList = new List<DetectVehicleResponse.DetectVehicle_Data.DetectVehicle_DetectObjectInfo>();
			for (int i = 0; i < context.Length("DetectVehicle.Data.DetectObjectInfoList.Length"); i++) {
				DetectVehicleResponse.DetectVehicle_Data.DetectVehicle_DetectObjectInfo detectObjectInfo = new DetectVehicleResponse.DetectVehicle_Data.DetectVehicle_DetectObjectInfo();
				detectObjectInfo.Score = context.FloatValue("DetectVehicle.Data.DetectObjectInfoList["+ i +"].Score");
				detectObjectInfo.Type = context.StringValue("DetectVehicle.Data.DetectObjectInfoList["+ i +"].Type");
				detectObjectInfo.Id = context.IntegerValue("DetectVehicle.Data.DetectObjectInfoList["+ i +"].Id");

				List<string> detectObjectInfo_boxes = new List<string>();
				for (int j = 0; j < context.Length("DetectVehicle.Data.DetectObjectInfoList["+ i +"].Boxes.Length"); j++) {
					detectObjectInfo_boxes.Add(context.StringValue("DetectVehicle.Data.DetectObjectInfoList["+ i +"].Boxes["+ j +"]"));
				}
				detectObjectInfo.Boxes = detectObjectInfo_boxes;

				data_detectObjectInfoList.Add(detectObjectInfo);
			}
			data.DetectObjectInfoList = data_detectObjectInfoList;
			detectVehicleResponse.Data = data;
        
			return detectVehicleResponse;
        }
    }
}
