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
    public class SearchRetcodeAppByPageResponseUnmarshaller
    {
        public static SearchRetcodeAppByPageResponse Unmarshall(UnmarshallerContext context)
        {
			SearchRetcodeAppByPageResponse searchRetcodeAppByPageResponse = new SearchRetcodeAppByPageResponse();

			searchRetcodeAppByPageResponse.HttpResponse = context.HttpResponse;
			searchRetcodeAppByPageResponse.RequestId = context.StringValue("SearchRetcodeAppByPage.RequestId");

			SearchRetcodeAppByPageResponse.SearchRetcodeAppByPage_PageBean pageBean = new SearchRetcodeAppByPageResponse.SearchRetcodeAppByPage_PageBean();
			pageBean.TotalCount = context.IntegerValue("SearchRetcodeAppByPage.PageBean.TotalCount");
			pageBean.PageNumber = context.IntegerValue("SearchRetcodeAppByPage.PageBean.PageNumber");
			pageBean.PageSize = context.IntegerValue("SearchRetcodeAppByPage.PageBean.PageSize");

			List<SearchRetcodeAppByPageResponse.SearchRetcodeAppByPage_PageBean.SearchRetcodeAppByPage_RetcodeApp> pageBean_retcodeApps = new List<SearchRetcodeAppByPageResponse.SearchRetcodeAppByPage_PageBean.SearchRetcodeAppByPage_RetcodeApp>();
			for (int i = 0; i < context.Length("SearchRetcodeAppByPage.PageBean.RetcodeApps.Length"); i++) {
				SearchRetcodeAppByPageResponse.SearchRetcodeAppByPage_PageBean.SearchRetcodeAppByPage_RetcodeApp retcodeApp = new SearchRetcodeAppByPageResponse.SearchRetcodeAppByPage_PageBean.SearchRetcodeAppByPage_RetcodeApp();
				retcodeApp.AppId = context.LongValue("SearchRetcodeAppByPage.PageBean.RetcodeApps["+ i +"].AppId");
				retcodeApp.Pid = context.StringValue("SearchRetcodeAppByPage.PageBean.RetcodeApps["+ i +"].Pid");
				retcodeApp.AppName = context.StringValue("SearchRetcodeAppByPage.PageBean.RetcodeApps["+ i +"].AppName");
				retcodeApp.Type = context.StringValue("SearchRetcodeAppByPage.PageBean.RetcodeApps["+ i +"].Type");
				retcodeApp.UserId = context.StringValue("SearchRetcodeAppByPage.PageBean.RetcodeApps["+ i +"].UserId");
				retcodeApp.RegionId = context.StringValue("SearchRetcodeAppByPage.PageBean.RetcodeApps["+ i +"].RegionId");
				retcodeApp.CreateTime = context.LongValue("SearchRetcodeAppByPage.PageBean.RetcodeApps["+ i +"].CreateTime");
				retcodeApp.UpdateTime = context.LongValue("SearchRetcodeAppByPage.PageBean.RetcodeApps["+ i +"].UpdateTime");

				pageBean_retcodeApps.Add(retcodeApp);
			}
			pageBean.RetcodeApps = pageBean_retcodeApps;
			searchRetcodeAppByPageResponse.PageBean = pageBean;
        
			return searchRetcodeAppByPageResponse;
        }
    }
}
