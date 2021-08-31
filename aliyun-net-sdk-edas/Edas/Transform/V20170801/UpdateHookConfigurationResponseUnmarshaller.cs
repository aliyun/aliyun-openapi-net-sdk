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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class UpdateHookConfigurationResponseUnmarshaller
    {
        public static UpdateHookConfigurationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateHookConfigurationResponse updateHookConfigurationResponse = new UpdateHookConfigurationResponse();

			updateHookConfigurationResponse.HttpResponse = _ctx.HttpResponse;
			updateHookConfigurationResponse.RequestId = _ctx.StringValue("UpdateHookConfiguration.RequestId");
			updateHookConfigurationResponse.Code = _ctx.IntegerValue("UpdateHookConfiguration.Code");
			updateHookConfigurationResponse.Message = _ctx.StringValue("UpdateHookConfiguration.Message");

			List<UpdateHookConfigurationResponse.UpdateHookConfiguration_Configuration> updateHookConfigurationResponse_hooksConfiguration = new List<UpdateHookConfigurationResponse.UpdateHookConfiguration_Configuration>();
			for (int i = 0; i < _ctx.Length("UpdateHookConfiguration.HooksConfiguration.Length"); i++) {
				UpdateHookConfigurationResponse.UpdateHookConfiguration_Configuration configuration = new UpdateHookConfigurationResponse.UpdateHookConfiguration_Configuration();
				configuration.Name = _ctx.StringValue("UpdateHookConfiguration.HooksConfiguration["+ i +"].Name");
				configuration.Script = _ctx.StringValue("UpdateHookConfiguration.HooksConfiguration["+ i +"].Script");
				configuration.IgnoreFail = _ctx.BooleanValue("UpdateHookConfiguration.HooksConfiguration["+ i +"].IgnoreFail");

				updateHookConfigurationResponse_hooksConfiguration.Add(configuration);
			}
			updateHookConfigurationResponse.HooksConfiguration = updateHookConfigurationResponse_hooksConfiguration;
        
			return updateHookConfigurationResponse;
        }
    }
}
