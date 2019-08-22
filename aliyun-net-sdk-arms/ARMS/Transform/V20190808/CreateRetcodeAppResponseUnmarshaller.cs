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
using Aliyun.Acs.ARMS.Model.V20190808;

namespace Aliyun.Acs.ARMS.Transform.V20190808
{
    public class CreateRetcodeAppResponseUnmarshaller
    {
        public static CreateRetcodeAppResponse Unmarshall(UnmarshallerContext context)
        {
			CreateRetcodeAppResponse createRetcodeAppResponse = new CreateRetcodeAppResponse();

			createRetcodeAppResponse.HttpResponse = context.HttpResponse;
			createRetcodeAppResponse.RequestId = context.StringValue("CreateRetcodeApp.RequestId");

			CreateRetcodeAppResponse.CreateRetcodeApp_RetcodeAppDataBean retcodeAppDataBean = new CreateRetcodeAppResponse.CreateRetcodeApp_RetcodeAppDataBean();
			retcodeAppDataBean.AppId = context.LongValue("CreateRetcodeApp.RetcodeAppDataBean.AppId");
			retcodeAppDataBean.Pid = context.StringValue("CreateRetcodeApp.RetcodeAppDataBean.Pid");
			createRetcodeAppResponse.RetcodeAppDataBean = retcodeAppDataBean;
        
			return createRetcodeAppResponse;
        }
    }
}
