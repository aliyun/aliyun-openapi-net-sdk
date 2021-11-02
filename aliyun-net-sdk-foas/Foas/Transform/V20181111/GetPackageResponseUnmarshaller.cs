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
        public static GetPackageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetPackageResponse getPackageResponse = new GetPackageResponse();

			getPackageResponse.HttpResponse = _ctx.HttpResponse;
			getPackageResponse.RequestId = _ctx.StringValue("GetPackage.RequestId");

			GetPackageResponse.GetPackage_Package package = new GetPackageResponse.GetPackage_Package();
			package.ProjectName = _ctx.StringValue("GetPackage.Package.ProjectName");
			package.PackageName = _ctx.StringValue("GetPackage.Package.PackageName");
			package.Creator = _ctx.StringValue("GetPackage.Package.Creator");
			package.Modifier = _ctx.StringValue("GetPackage.Package.Modifier");
			package.CreateTime = _ctx.LongValue("GetPackage.Package.CreateTime");
			package.ModifyTime = _ctx.LongValue("GetPackage.Package.ModifyTime");
			package.OriginName = _ctx.StringValue("GetPackage.Package.OriginName");
			package.Type = _ctx.StringValue("GetPackage.Package.Type");
			package.Md5 = _ctx.StringValue("GetPackage.Package.Md5");
			package.Description = _ctx.StringValue("GetPackage.Package.Description");
			package.OssEndpoint = _ctx.StringValue("GetPackage.Package.OssEndpoint");
			package.OssBucket = _ctx.StringValue("GetPackage.Package.OssBucket");
			package.OssOwner = _ctx.StringValue("GetPackage.Package.OssOwner");
			package.OssPath = _ctx.StringValue("GetPackage.Package.OssPath");
			package.Tag = _ctx.StringValue("GetPackage.Package.Tag");
			package.ScanLink = _ctx.StringValue("GetPackage.Package.ScanLink");
			package.ScanState = _ctx.StringValue("GetPackage.Package.ScanState");
			package.ScanErrorMessage = _ctx.StringValue("GetPackage.Package.ScanErrorMessage");
			package.ScanExtBizNo = _ctx.StringValue("GetPackage.Package.ScanExtBizNo");
			getPackageResponse.Package = package;
        
			return getPackageResponse;
        }
    }
}
