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
    public class GetPackageResponseUnmarshaller
    {
        public static GetPackageResponse Unmarshall(UnmarshallerContext context)
        {
			GetPackageResponse getPackageResponse = new GetPackageResponse();

			getPackageResponse.HttpResponse = context.HttpResponse;
			getPackageResponse.RequestId = context.StringValue("GetPackage.RequestId");

			GetPackageResponse.GetPackage_Package package = new GetPackageResponse.GetPackage_Package();
			package.ProjectName = context.StringValue("GetPackage.Package.ProjectName");
			package.PackageName = context.StringValue("GetPackage.Package.PackageName");
			package.Creator = context.StringValue("GetPackage.Package.Creator");
			package.Modifier = context.StringValue("GetPackage.Package.Modifier");
			package.CreateTime = context.LongValue("GetPackage.Package.CreateTime");
			package.ModifyTime = context.LongValue("GetPackage.Package.ModifyTime");
			package.OriginName = context.StringValue("GetPackage.Package.OriginName");
			package.Type = context.StringValue("GetPackage.Package.Type");
			package.Md5 = context.StringValue("GetPackage.Package.Md5");
			package.Description = context.StringValue("GetPackage.Package.Description");
			package.OssEndpoint = context.StringValue("GetPackage.Package.OssEndpoint");
			package.OssBucket = context.StringValue("GetPackage.Package.OssBucket");
			package.OssOwner = context.StringValue("GetPackage.Package.OssOwner");
			package.OssPath = context.StringValue("GetPackage.Package.OssPath");
			package.Tag = context.StringValue("GetPackage.Package.Tag");
			getPackageResponse.Package = package;
        
			return getPackageResponse;
        }
    }
}
