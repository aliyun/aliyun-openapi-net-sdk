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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Cms.Model.V20180308;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cms.Transform.V20180308
{
    public class NodeInstallResponseUnmarshaller
    {
        public static NodeInstallResponse Unmarshall(UnmarshallerContext context)
        {
			NodeInstallResponse nodeInstallResponse = new NodeInstallResponse();

			nodeInstallResponse.HttpResponse = context.HttpResponse;
			nodeInstallResponse.ErrorCode = context.IntegerValue("NodeInstall.ErrorCode");
			nodeInstallResponse.ErrorMessage = context.StringValue("NodeInstall.ErrorMessage");
			nodeInstallResponse.Success = context.BooleanValue("NodeInstall.Success");
			nodeInstallResponse.RequestId = context.StringValue("NodeInstall.RequestId");
        
			return nodeInstallResponse;
        }
    }
}