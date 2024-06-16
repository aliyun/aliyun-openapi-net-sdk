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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeWhitelistTemplateLinkedInstanceResponseUnmarshaller
    {
        public static DescribeWhitelistTemplateLinkedInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeWhitelistTemplateLinkedInstanceResponse describeWhitelistTemplateLinkedInstanceResponse = new DescribeWhitelistTemplateLinkedInstanceResponse();

			describeWhitelistTemplateLinkedInstanceResponse.HttpResponse = _ctx.HttpResponse;
			describeWhitelistTemplateLinkedInstanceResponse.RequestId = _ctx.StringValue("DescribeWhitelistTemplateLinkedInstance.RequestId");
			describeWhitelistTemplateLinkedInstanceResponse.Success = _ctx.BooleanValue("DescribeWhitelistTemplateLinkedInstance.Success");
			describeWhitelistTemplateLinkedInstanceResponse.Code = _ctx.StringValue("DescribeWhitelistTemplateLinkedInstance.Code");
			describeWhitelistTemplateLinkedInstanceResponse.Message = _ctx.StringValue("DescribeWhitelistTemplateLinkedInstance.Message");
			describeWhitelistTemplateLinkedInstanceResponse.HttpStatusCode = _ctx.IntegerValue("DescribeWhitelistTemplateLinkedInstance.HttpStatusCode");

			DescribeWhitelistTemplateLinkedInstanceResponse.DescribeWhitelistTemplateLinkedInstance_Data data = new DescribeWhitelistTemplateLinkedInstanceResponse.DescribeWhitelistTemplateLinkedInstance_Data();
			data.TemplateId = _ctx.IntegerValue("DescribeWhitelistTemplateLinkedInstance.Data.TemplateId");

			List<string> data_insName = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeWhitelistTemplateLinkedInstance.Data.InsName.Length"); i++) {
				data_insName.Add(_ctx.StringValue("DescribeWhitelistTemplateLinkedInstance.Data.InsName["+ i +"]"));
			}
			data.InsName = data_insName;
			describeWhitelistTemplateLinkedInstanceResponse.Data = data;
        
			return describeWhitelistTemplateLinkedInstanceResponse;
        }
    }
}
