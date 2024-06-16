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
using Aliyun.Acs.cloud_siem.Model.V20220616;

namespace Aliyun.Acs.cloud_siem.Transform.V20220616
{
    public class DescribeAlertSceneByEventResponseUnmarshaller
    {
        public static DescribeAlertSceneByEventResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAlertSceneByEventResponse describeAlertSceneByEventResponse = new DescribeAlertSceneByEventResponse();

			describeAlertSceneByEventResponse.HttpResponse = _ctx.HttpResponse;
			describeAlertSceneByEventResponse.Success = _ctx.BooleanValue("DescribeAlertSceneByEvent.Success");
			describeAlertSceneByEventResponse.Code = _ctx.IntegerValue("DescribeAlertSceneByEvent.Code");
			describeAlertSceneByEventResponse.Message = _ctx.StringValue("DescribeAlertSceneByEvent.Message");
			describeAlertSceneByEventResponse.RequestId = _ctx.StringValue("DescribeAlertSceneByEvent.RequestId");

			List<DescribeAlertSceneByEventResponse.DescribeAlertSceneByEvent_DataItem> describeAlertSceneByEventResponse_data = new List<DescribeAlertSceneByEventResponse.DescribeAlertSceneByEvent_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeAlertSceneByEvent.Data.Length"); i++) {
				DescribeAlertSceneByEventResponse.DescribeAlertSceneByEvent_DataItem dataItem = new DescribeAlertSceneByEventResponse.DescribeAlertSceneByEvent_DataItem();
				dataItem.AlertType = _ctx.StringValue("DescribeAlertSceneByEvent.Data["+ i +"].AlertType");
				dataItem.AlertTypeId = _ctx.StringValue("DescribeAlertSceneByEvent.Data["+ i +"].AlertTypeId");
				dataItem.AlertName = _ctx.StringValue("DescribeAlertSceneByEvent.Data["+ i +"].AlertName");
				dataItem.AlertNameId = _ctx.StringValue("DescribeAlertSceneByEvent.Data["+ i +"].AlertNameId");
				dataItem.AlertTile = _ctx.StringValue("DescribeAlertSceneByEvent.Data["+ i +"].AlertTile");
				dataItem.AlertTileId = _ctx.StringValue("DescribeAlertSceneByEvent.Data["+ i +"].AlertTileId");

				List<DescribeAlertSceneByEventResponse.DescribeAlertSceneByEvent_DataItem.DescribeAlertSceneByEvent_Target> dataItem_targets = new List<DescribeAlertSceneByEventResponse.DescribeAlertSceneByEvent_DataItem.DescribeAlertSceneByEvent_Target>();
				for (int j = 0; j < _ctx.Length("DescribeAlertSceneByEvent.Data["+ i +"].Targets.Length"); j++) {
					DescribeAlertSceneByEventResponse.DescribeAlertSceneByEvent_DataItem.DescribeAlertSceneByEvent_Target target = new DescribeAlertSceneByEventResponse.DescribeAlertSceneByEvent_DataItem.DescribeAlertSceneByEvent_Target();
					target.Type = _ctx.StringValue("DescribeAlertSceneByEvent.Data["+ i +"].Targets["+ j +"].Type");
					target.Name = _ctx.StringValue("DescribeAlertSceneByEvent.Data["+ i +"].Targets["+ j +"].Name");
					target._Value = _ctx.StringValue("DescribeAlertSceneByEvent.Data["+ i +"].Targets["+ j +"].Value");

					List<string> target_values = new List<string>();
					for (int k = 0; k < _ctx.Length("DescribeAlertSceneByEvent.Data["+ i +"].Targets["+ j +"].Values.Length"); k++) {
						target_values.Add(_ctx.StringValue("DescribeAlertSceneByEvent.Data["+ i +"].Targets["+ j +"].Values["+ k +"]"));
					}
					target.Values = target_values;

					dataItem_targets.Add(target);
				}
				dataItem.Targets = dataItem_targets;

				describeAlertSceneByEventResponse_data.Add(dataItem);
			}
			describeAlertSceneByEventResponse.Data = describeAlertSceneByEventResponse_data;
        
			return describeAlertSceneByEventResponse;
        }
    }
}
