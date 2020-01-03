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
using Aliyun.Acs.EHPC.Model.V20180412;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class GetWorkbenchTokenResponseUnmarshaller
    {
        public static GetWorkbenchTokenResponse Unmarshall(UnmarshallerContext context)
        {
			GetWorkbenchTokenResponse getWorkbenchTokenResponse = new GetWorkbenchTokenResponse();

			getWorkbenchTokenResponse.HttpResponse = context.HttpResponse;
			getWorkbenchTokenResponse.RequestId = context.StringValue("GetWorkbenchToken.RequestId");

			GetWorkbenchTokenResponse.GetWorkbenchToken_Root root = new GetWorkbenchTokenResponse.GetWorkbenchToken_Root();

			GetWorkbenchTokenResponse.GetWorkbenchToken_Root.GetWorkbenchToken_InstanceLoginView instanceLoginView = new GetWorkbenchTokenResponse.GetWorkbenchToken_Root.GetWorkbenchToken_InstanceLoginView();
			instanceLoginView.ViewName = context.StringValue("GetWorkbenchToken.Root.InstanceLoginView.viewName");
			instanceLoginView.DefaultViewUrl = context.StringValue("GetWorkbenchToken.Root.InstanceLoginView.defaultViewUrl");
			instanceLoginView.BaseViewUrl = context.StringValue("GetWorkbenchToken.Root.InstanceLoginView.baseViewUrl");
			instanceLoginView.TerminalViewUrl = context.StringValue("GetWorkbenchToken.Root.InstanceLoginView.terminalViewUrl");
			instanceLoginView.FileTreeViewUrl = context.StringValue("GetWorkbenchToken.Root.InstanceLoginView.fileTreeViewUrl");
			instanceLoginView.RdpViewUrl = context.StringValue("GetWorkbenchToken.Root.InstanceLoginView.rdpViewUrl");
			root.InstanceLoginView = instanceLoginView;
			getWorkbenchTokenResponse.Root = root;
        
			return getWorkbenchTokenResponse;
        }
    }
}
