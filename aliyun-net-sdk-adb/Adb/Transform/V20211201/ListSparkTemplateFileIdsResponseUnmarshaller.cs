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
    public class ListSparkTemplateFileIdsResponseUnmarshaller
    {
        public static ListSparkTemplateFileIdsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSparkTemplateFileIdsResponse listSparkTemplateFileIdsResponse = new ListSparkTemplateFileIdsResponse();

			listSparkTemplateFileIdsResponse.HttpResponse = _ctx.HttpResponse;
			listSparkTemplateFileIdsResponse.RequestId = _ctx.StringValue("ListSparkTemplateFileIds.RequestId");

			List<string> listSparkTemplateFileIdsResponse_data = new List<string>();
			for (int i = 0; i < _ctx.Length("ListSparkTemplateFileIds.Data.Length"); i++) {
				listSparkTemplateFileIdsResponse_data.Add(_ctx.StringValue("ListSparkTemplateFileIds.Data["+ i +"]"));
			}
			listSparkTemplateFileIdsResponse.Data = listSparkTemplateFileIdsResponse_data;
        
			return listSparkTemplateFileIdsResponse;
        }
    }
}
