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
using Aliyun.Acs.eflo.Model.V20220530;

namespace Aliyun.Acs.eflo.Transform.V20220530
{
    public class GetFabricTopologyResponseUnmarshaller
    {
        public static GetFabricTopologyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetFabricTopologyResponse getFabricTopologyResponse = new GetFabricTopologyResponse();

			getFabricTopologyResponse.HttpResponse = _ctx.HttpResponse;
			getFabricTopologyResponse.Code = _ctx.IntegerValue("GetFabricTopology.Code");
			getFabricTopologyResponse.Message = _ctx.StringValue("GetFabricTopology.Message");
			getFabricTopologyResponse.RequestId = _ctx.StringValue("GetFabricTopology.RequestId");

			GetFabricTopologyResponse.GetFabricTopology_Content content = new GetFabricTopologyResponse.GetFabricTopology_Content();
			content.RegionId = _ctx.StringValue("GetFabricTopology.Content.RegionId");
			content.VpdId = _ctx.StringValue("GetFabricTopology.Content.VpdId");

			List<GetFabricTopologyResponse.GetFabricTopology_Content.GetFabricTopology_Layer> content_topoInfo = new List<GetFabricTopologyResponse.GetFabricTopology_Content.GetFabricTopology_Layer>();
			for (int i = 0; i < _ctx.Length("GetFabricTopology.Content.TopoInfo.Length"); i++) {
				GetFabricTopologyResponse.GetFabricTopology_Content.GetFabricTopology_Layer layer = new GetFabricTopologyResponse.GetFabricTopology_Content.GetFabricTopology_Layer();
				layer.LayerType = _ctx.StringValue("GetFabricTopology.Content.TopoInfo["+ i +"].LayerType");
				layer.LayerName = _ctx.StringValue("GetFabricTopology.Content.TopoInfo["+ i +"].LayerName");

				List<string> layer_nextLayer = new List<string>();
				for (int j = 0; j < _ctx.Length("GetFabricTopology.Content.TopoInfo["+ i +"].NextLayer.Length"); j++) {
					layer_nextLayer.Add(_ctx.StringValue("GetFabricTopology.Content.TopoInfo["+ i +"].NextLayer["+ j +"]"));
				}
				layer.NextLayer = layer_nextLayer;

				content_topoInfo.Add(layer);
			}
			content.TopoInfo = content_topoInfo;
			getFabricTopologyResponse.Content = content;
        
			return getFabricTopologyResponse;
        }
    }
}
