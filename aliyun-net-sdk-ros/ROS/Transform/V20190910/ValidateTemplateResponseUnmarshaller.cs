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
using Aliyun.Acs.ROS.Model.V20190910;

namespace Aliyun.Acs.ROS.Transform.V20190910
{
    public class ValidateTemplateResponseUnmarshaller
    {
        public static ValidateTemplateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ValidateTemplateResponse validateTemplateResponse = new ValidateTemplateResponse();

			validateTemplateResponse.HttpResponse = _ctx.HttpResponse;
			validateTemplateResponse.Description = _ctx.StringValue("ValidateTemplate.Description");
			validateTemplateResponse.RequestId = _ctx.StringValue("ValidateTemplate.RequestId");

			List<Dictionary<string, string>> validateTemplateResponse_parameters = new List<Dictionary<string, string>>();
			for (int i = 0; i < _ctx.Length("ValidateTemplate.Parameters.Length"); i++) {
				Dictionary<string, string> tmp = new Dictionary<string, string>() { };
				foreach (var _item in _ctx.ResponseDictionary){
					string prefix = "ValidateTemplate.Parameters["+ i +"].";
					if (_item.Key.IndexOf(prefix) == 0){
						tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
					}
				}
				if (tmp.Count > 0){
					validateTemplateResponse_parameters.Add(tmp);
				}
			}
			validateTemplateResponse.Parameters = validateTemplateResponse_parameters;
        
			return validateTemplateResponse;
        }
    }
}
