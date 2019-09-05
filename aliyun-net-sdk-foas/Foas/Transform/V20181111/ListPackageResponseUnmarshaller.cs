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
using Aliyun.Acs.foas.Model.V20181111;

namespace Aliyun.Acs.foas.Transform.V20181111
{
    public class ListPackageResponseUnmarshaller
    {
        public static ListPackageResponse Unmarshall(UnmarshallerContext context)
        {
			ListPackageResponse listPackageResponse = new ListPackageResponse();

			listPackageResponse.HttpResponse = context.HttpResponse;
			listPackageResponse.RequestId = context.StringValue("ListPackage.RequestId");
			listPackageResponse.PageIndex = context.IntegerValue("ListPackage.PageIndex");
			listPackageResponse.PageSize = context.IntegerValue("ListPackage.PageSize");
			listPackageResponse.TotalPage = context.IntegerValue("ListPackage.TotalPage");
			listPackageResponse.TotalCount = context.LongValue("ListPackage.TotalCount");

			List<ListPackageResponse.ListPackage_Package> listPackageResponse_packages = new List<ListPackageResponse.ListPackage_Package>();
			for (int i = 0; i < context.Length("ListPackage.Packages.Length"); i++) {
				ListPackageResponse.ListPackage_Package package = new ListPackageResponse.ListPackage_Package();
				package.ProjectName = context.StringValue("ListPackage.Packages["+ i +"].ProjectName");
				package.PackageName = context.StringValue("ListPackage.Packages["+ i +"].PackageName");
				package.Creator = context.StringValue("ListPackage.Packages["+ i +"].Creator");
				package.Modifier = context.StringValue("ListPackage.Packages["+ i +"].Modifier");
				package.CreateTime = context.LongValue("ListPackage.Packages["+ i +"].CreateTime");
				package.ModifyTime = context.LongValue("ListPackage.Packages["+ i +"].ModifyTime");
				package.OriginName = context.StringValue("ListPackage.Packages["+ i +"].OriginName");
				package.Type = context.StringValue("ListPackage.Packages["+ i +"].Type");
				package.Md5 = context.StringValue("ListPackage.Packages["+ i +"].Md5");
				package.Description = context.StringValue("ListPackage.Packages["+ i +"].Description");
				package.OssEndpoint = context.StringValue("ListPackage.Packages["+ i +"].OssEndpoint");
				package.OssBucket = context.StringValue("ListPackage.Packages["+ i +"].OssBucket");
				package.OssOwner = context.StringValue("ListPackage.Packages["+ i +"].OssOwner");
				package.OssPath = context.StringValue("ListPackage.Packages["+ i +"].OssPath");
				package.Tag = context.StringValue("ListPackage.Packages["+ i +"].Tag");

				listPackageResponse_packages.Add(package);
			}
			listPackageResponse.Packages = listPackageResponse_packages;
        
			return listPackageResponse;
        }
    }
}
