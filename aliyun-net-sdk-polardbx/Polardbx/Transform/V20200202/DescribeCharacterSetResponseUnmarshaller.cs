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
using Aliyun.Acs.polardbx.Model.V20200202;

namespace Aliyun.Acs.polardbx.Transform.V20200202
{
    public class DescribeCharacterSetResponseUnmarshaller
    {
        public static DescribeCharacterSetResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCharacterSetResponse describeCharacterSetResponse = new DescribeCharacterSetResponse();

			describeCharacterSetResponse.HttpResponse = _ctx.HttpResponse;
			describeCharacterSetResponse.RequestId = _ctx.StringValue("DescribeCharacterSet.RequestId");
			describeCharacterSetResponse.Success = _ctx.BooleanValue("DescribeCharacterSet.Success");
			describeCharacterSetResponse.Message = _ctx.StringValue("DescribeCharacterSet.Message");

			DescribeCharacterSetResponse.DescribeCharacterSet_Data data = new DescribeCharacterSetResponse.DescribeCharacterSet_Data();
			data.Engine = _ctx.StringValue("DescribeCharacterSet.Data.Engine");

			List<string> data_characterSet = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeCharacterSet.Data.CharacterSet.Length"); i++) {
				data_characterSet.Add(_ctx.StringValue("DescribeCharacterSet.Data.CharacterSet["+ i +"]"));
			}
			data.CharacterSet = data_characterSet;
			describeCharacterSetResponse.Data = data;
        
			return describeCharacterSetResponse;
        }
    }
}
