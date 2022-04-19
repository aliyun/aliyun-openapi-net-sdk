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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class GetMetaTableIntroWikiResponseUnmarshaller
    {
        public static GetMetaTableIntroWikiResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetMetaTableIntroWikiResponse getMetaTableIntroWikiResponse = new GetMetaTableIntroWikiResponse();

			getMetaTableIntroWikiResponse.HttpResponse = _ctx.HttpResponse;
			getMetaTableIntroWikiResponse.HttpStatusCode = _ctx.IntegerValue("GetMetaTableIntroWiki.HttpStatusCode");
			getMetaTableIntroWikiResponse.ErrorMessage = _ctx.StringValue("GetMetaTableIntroWiki.ErrorMessage");
			getMetaTableIntroWikiResponse.RequestId = _ctx.StringValue("GetMetaTableIntroWiki.RequestId");
			getMetaTableIntroWikiResponse.Success = _ctx.BooleanValue("GetMetaTableIntroWiki.Success");
			getMetaTableIntroWikiResponse.ErrorCode = _ctx.StringValue("GetMetaTableIntroWiki.ErrorCode");

			GetMetaTableIntroWikiResponse.GetMetaTableIntroWiki_Data data = new GetMetaTableIntroWikiResponse.GetMetaTableIntroWiki_Data();
			data.ModifiedTime = _ctx.LongValue("GetMetaTableIntroWiki.Data.ModifiedTime");
			data.Version = _ctx.LongValue("GetMetaTableIntroWiki.Data.Version");
			data.CreateTime = _ctx.LongValue("GetMetaTableIntroWiki.Data.CreateTime");
			data.CreatorName = _ctx.StringValue("GetMetaTableIntroWiki.Data.CreatorName");
			data.Content = _ctx.StringValue("GetMetaTableIntroWiki.Data.Content");
			data.Creator = _ctx.StringValue("GetMetaTableIntroWiki.Data.Creator");
			getMetaTableIntroWikiResponse.Data = data;
        
			return getMetaTableIntroWikiResponse;
        }
    }
}
