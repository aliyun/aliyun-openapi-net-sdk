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
    public class DescribeAlertSceneResponseUnmarshaller
    {
        public static DescribeAlertSceneResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAlertSceneResponse describeAlertSceneResponse = new DescribeAlertSceneResponse();

			describeAlertSceneResponse.HttpResponse = _ctx.HttpResponse;
			describeAlertSceneResponse.Success = _ctx.BooleanValue("DescribeAlertScene.Success");
			describeAlertSceneResponse.Code = _ctx.IntegerValue("DescribeAlertScene.Code");
			describeAlertSceneResponse.Message = _ctx.StringValue("DescribeAlertScene.Message");
			describeAlertSceneResponse.RequestId = _ctx.StringValue("DescribeAlertScene.RequestId");

			List<DescribeAlertSceneResponse.DescribeAlertScene_DataItem> describeAlertSceneResponse_data = new List<DescribeAlertSceneResponse.DescribeAlertScene_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeAlertScene.Data.Length"); i++) {
				DescribeAlertSceneResponse.DescribeAlertScene_DataItem dataItem = new DescribeAlertSceneResponse.DescribeAlertScene_DataItem();
				dataItem.AlertType = _ctx.StringValue("DescribeAlertScene.Data["+ i +"].AlertType");
				dataItem.AlertTypeId = _ctx.StringValue("DescribeAlertScene.Data["+ i +"].AlertTypeId");
				dataItem.AlertName = _ctx.StringValue("DescribeAlertScene.Data["+ i +"].AlertName");
				dataItem.AlertNameId = _ctx.StringValue("DescribeAlertScene.Data["+ i +"].AlertNameId");
				dataItem.AlertTile = _ctx.StringValue("DescribeAlertScene.Data["+ i +"].AlertTile");
				dataItem.AlertTileId = _ctx.StringValue("DescribeAlertScene.Data["+ i +"].AlertTileId");

				List<DescribeAlertSceneResponse.DescribeAlertScene_DataItem.DescribeAlertScene_Target> dataItem_targets = new List<DescribeAlertSceneResponse.DescribeAlertScene_DataItem.DescribeAlertScene_Target>();
				for (int j = 0; j < _ctx.Length("DescribeAlertScene.Data["+ i +"].Targets.Length"); j++) {
					DescribeAlertSceneResponse.DescribeAlertScene_DataItem.DescribeAlertScene_Target target = new DescribeAlertSceneResponse.DescribeAlertScene_DataItem.DescribeAlertScene_Target();
					target.Type = _ctx.StringValue("DescribeAlertScene.Data["+ i +"].Targets["+ j +"].Type");
					target.Name = _ctx.StringValue("DescribeAlertScene.Data["+ i +"].Targets["+ j +"].Name");
					target._Value = _ctx.StringValue("DescribeAlertScene.Data["+ i +"].Targets["+ j +"].Value");

					List<string> target_values = new List<string>();
					for (int k = 0; k < _ctx.Length("DescribeAlertScene.Data["+ i +"].Targets["+ j +"].Values.Length"); k++) {
						target_values.Add(_ctx.StringValue("DescribeAlertScene.Data["+ i +"].Targets["+ j +"].Values["+ k +"]"));
					}
					target.Values = target_values;

					dataItem_targets.Add(target);
				}
				dataItem.Targets = dataItem_targets;

				describeAlertSceneResponse_data.Add(dataItem);
			}
			describeAlertSceneResponse.Data = describeAlertSceneResponse_data;
        
			return describeAlertSceneResponse;
        }
    }
}
