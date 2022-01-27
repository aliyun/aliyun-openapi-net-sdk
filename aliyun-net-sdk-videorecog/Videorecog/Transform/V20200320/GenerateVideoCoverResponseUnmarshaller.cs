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
using Aliyun.Acs.videorecog.Model.V20200320;

namespace Aliyun.Acs.videorecog.Transform.V20200320
{
    public class GenerateVideoCoverResponseUnmarshaller
    {
        public static GenerateVideoCoverResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GenerateVideoCoverResponse generateVideoCoverResponse = new GenerateVideoCoverResponse();

			generateVideoCoverResponse.HttpResponse = _ctx.HttpResponse;
			generateVideoCoverResponse.RequestId = _ctx.StringValue("GenerateVideoCover.RequestId");

			GenerateVideoCoverResponse.GenerateVideoCover_Data data = new GenerateVideoCoverResponse.GenerateVideoCover_Data();

			List<GenerateVideoCoverResponse.GenerateVideoCover_Data.GenerateVideoCover_Output> data_outputs = new List<GenerateVideoCoverResponse.GenerateVideoCover_Data.GenerateVideoCover_Output>();
			for (int i = 0; i < _ctx.Length("GenerateVideoCover.Data.Outputs.Length"); i++) {
				GenerateVideoCoverResponse.GenerateVideoCover_Data.GenerateVideoCover_Output output = new GenerateVideoCoverResponse.GenerateVideoCover_Data.GenerateVideoCover_Output();
				output.ImageURL = _ctx.StringValue("GenerateVideoCover.Data.Outputs["+ i +"].ImageURL");
				output.Confidence = _ctx.FloatValue("GenerateVideoCover.Data.Outputs["+ i +"].Confidence");

				data_outputs.Add(output);
			}
			data.Outputs = data_outputs;
			generateVideoCoverResponse.Data = data;
        
			return generateVideoCoverResponse;
        }
    }
}
