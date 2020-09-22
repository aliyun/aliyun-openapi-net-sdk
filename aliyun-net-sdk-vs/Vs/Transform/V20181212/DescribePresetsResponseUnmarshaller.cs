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
using Aliyun.Acs.vs.Model.V20181212;

namespace Aliyun.Acs.vs.Transform.V20181212
{
    public class DescribePresetsResponseUnmarshaller
    {
        public static DescribePresetsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribePresetsResponse describePresetsResponse = new DescribePresetsResponse();

			describePresetsResponse.HttpResponse = context.HttpResponse;
			describePresetsResponse.RequestId = context.StringValue("DescribePresets.RequestId");
			describePresetsResponse.Id = context.StringValue("DescribePresets.Id");

			List<DescribePresetsResponse.DescribePresets_Preset> describePresetsResponse_presets = new List<DescribePresetsResponse.DescribePresets_Preset>();
			for (int i = 0; i < context.Length("DescribePresets.Presets.Length"); i++) {
				DescribePresetsResponse.DescribePresets_Preset preset = new DescribePresetsResponse.DescribePresets_Preset();
				preset.Id = context.StringValue("DescribePresets.Presets["+ i +"].Id");
				preset.Name = context.StringValue("DescribePresets.Presets["+ i +"].Name");

				describePresetsResponse_presets.Add(preset);
			}
			describePresetsResponse.Presets = describePresetsResponse_presets;
        
			return describePresetsResponse;
        }
    }
}
