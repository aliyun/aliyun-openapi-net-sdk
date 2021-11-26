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
using Aliyun.Acs.Qualitycheck.Model.V20190115;

namespace Aliyun.Acs.Qualitycheck.Transform.V20190115
{
    public class UploadRuleResponseUnmarshaller
    {
        public static UploadRuleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UploadRuleResponse uploadRuleResponse = new UploadRuleResponse();

			uploadRuleResponse.HttpResponse = _ctx.HttpResponse;
			uploadRuleResponse.Code = _ctx.StringValue("UploadRule.Code");
			uploadRuleResponse.Message = _ctx.StringValue("UploadRule.Message");
			uploadRuleResponse.RequestId = _ctx.StringValue("UploadRule.RequestId");
			uploadRuleResponse.Success = _ctx.BooleanValue("UploadRule.Success");

			List<string> uploadRuleResponse_data = new List<string>();
			for (int i = 0; i < _ctx.Length("UploadRule.Data.Length"); i++) {
				uploadRuleResponse_data.Add(_ctx.StringValue("UploadRule.Data["+ i +"]"));
			}
			uploadRuleResponse.Data = uploadRuleResponse_data;
        
			return uploadRuleResponse;
        }
    }
}
