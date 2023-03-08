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
using Aliyun.Acs.adb.Model.V20211201;

namespace Aliyun.Acs.adb.Transform.V20211201
{
    public class GetSparkTemplateFileContentResponseUnmarshaller
    {
        public static GetSparkTemplateFileContentResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSparkTemplateFileContentResponse getSparkTemplateFileContentResponse = new GetSparkTemplateFileContentResponse();

			getSparkTemplateFileContentResponse.HttpResponse = _ctx.HttpResponse;
			getSparkTemplateFileContentResponse.RequestId = _ctx.StringValue("GetSparkTemplateFileContent.RequestId");

			GetSparkTemplateFileContentResponse.GetSparkTemplateFileContent_Data data = new GetSparkTemplateFileContentResponse.GetSparkTemplateFileContent_Data();
			data.AppType = _ctx.StringValue("GetSparkTemplateFileContent.Data.AppType");
			data.Content = _ctx.StringValue("GetSparkTemplateFileContent.Data.Content");
			data.Id = _ctx.LongValue("GetSparkTemplateFileContent.Data.Id");
			data.Type = _ctx.StringValue("GetSparkTemplateFileContent.Data.Type");
			data.ResourceGroupName = _ctx.StringValue("GetSparkTemplateFileContent.Data.ResourceGroupName");
			getSparkTemplateFileContentResponse.Data = data;
        
			return getSparkTemplateFileContentResponse;
        }
    }
}
