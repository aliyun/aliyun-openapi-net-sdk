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
using Aliyun.Acs.Ecs.Model.V20151101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20151101
{
    public class OpsDetailImageResponseUnmarshaller
    {
        public static OpsDetailImageResponse Unmarshall(UnmarshallerContext context)
        {
			OpsDetailImageResponse opsDetailImageResponse = new OpsDetailImageResponse();

			opsDetailImageResponse.HttpResponse = context.HttpResponse;
			opsDetailImageResponse.RequestId = context.StringValue("OpsDetailImage.RequestId");
			opsDetailImageResponse.Id = context.LongValue("OpsDetailImage.Id");
			opsDetailImageResponse.Bid = context.StringValue("OpsDetailImage.Bid");
			opsDetailImageResponse.AliUid = context.LongValue("OpsDetailImage.AliUid");
			opsDetailImageResponse.ImageId = context.StringValue("OpsDetailImage.ImageId");
			opsDetailImageResponse.ImageSize = context.IntegerValue("OpsDetailImage.ImageSize");
			opsDetailImageResponse.ImageName = context.StringValue("OpsDetailImage.ImageName");
			opsDetailImageResponse.Remark = context.StringValue("OpsDetailImage.Remark");
			opsDetailImageResponse.Version = context.StringValue("OpsDetailImage.Version");
			opsDetailImageResponse.CreatedTime = context.StringValue("OpsDetailImage.CreatedTime");
			opsDetailImageResponse.ModifiedTime = context.StringValue("OpsDetailImage.ModifiedTime");
			opsDetailImageResponse.Status = context.StringValue("OpsDetailImage.Status");
			opsDetailImageResponse.SnapshotId = context.StringValue("OpsDetailImage.SnapshotId");
			opsDetailImageResponse.ProductCode = context.StringValue("OpsDetailImage.ProductCode");
			opsDetailImageResponse.RegionNo = context.StringValue("OpsDetailImage.RegionNo");
			opsDetailImageResponse.DisplayName = context.StringValue("OpsDetailImage.DisplayName");
			opsDetailImageResponse.ImageCategory = context.StringValue("OpsDetailImage.ImageCategory");
			opsDetailImageResponse.SrcImageId = context.LongValue("OpsDetailImage.SrcImageId");
			opsDetailImageResponse.SupportIoOptimizedInstance = context.BooleanValue("OpsDetailImage.SupportIoOptimizedInstance");

			OpsDetailImageResponse.OsTypeModel_ osTypeModel = new OpsDetailImageResponse.OsTypeModel_();
			osTypeModel.Type = context.StringValue("OpsDetailImage.OsTypeModel.Type");
			osTypeModel.Platform = context.StringValue("OpsDetailImage.OsTypeModel.Platform");
			osTypeModel.OsName = context.StringValue("OpsDetailImage.OsTypeModel.OsName");
			osTypeModel.OsBit = context.IntegerValue("OpsDetailImage.OsTypeModel.OsBit");
			osTypeModel.Remark = context.StringValue("OpsDetailImage.OsTypeModel.Remark");
			opsDetailImageResponse.OsTypeModel = osTypeModel;
        
			return opsDetailImageResponse;
        }
    }
}