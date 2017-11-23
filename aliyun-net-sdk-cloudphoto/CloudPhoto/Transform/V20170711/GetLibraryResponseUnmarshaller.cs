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
using Aliyun.Acs.CloudPhoto.Model.V20170711;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudPhoto.Transform.V20170711
{
    public class GetLibraryResponseUnmarshaller
    {
        public static GetLibraryResponse Unmarshall(UnmarshallerContext context)
        {
			GetLibraryResponse getLibraryResponse = new GetLibraryResponse();

			getLibraryResponse.HttpResponse = context.HttpResponse;
			getLibraryResponse.Code = context.StringValue("GetLibrary.Code");
			getLibraryResponse.Message = context.StringValue("GetLibrary.Message");
			getLibraryResponse.RequestId = context.StringValue("GetLibrary.RequestId");
			getLibraryResponse.Action = context.StringValue("GetLibrary.Action");

			GetLibraryResponse.GetLibrary_Library library = new GetLibraryResponse.GetLibrary_Library();

			GetLibraryResponse.GetLibrary_Library.GetLibrary_Quota quota = new GetLibraryResponse.GetLibrary_Library.GetLibrary_Quota();
			quota.TotalQuota = context.LongValue("GetLibrary.Library.Quota.TotalQuota");
			quota.FacesCount = context.IntegerValue("GetLibrary.Library.Quota.FacesCount");
			quota.PhotosCount = context.IntegerValue("GetLibrary.Library.Quota.PhotosCount");
			quota.UsedQuota = context.LongValue("GetLibrary.Library.Quota.UsedQuota");
			quota.VideosCount = context.IntegerValue("GetLibrary.Library.Quota.VideosCount");
			library.Quota = quota;

			GetLibraryResponse.GetLibrary_Library.GetLibrary_AutoCleanConfig autoCleanConfig = new GetLibraryResponse.GetLibrary_Library.GetLibrary_AutoCleanConfig();
			autoCleanConfig.AutoCleanEnabled = context.BooleanValue("GetLibrary.Library.AutoCleanConfig.AutoCleanEnabled");
			autoCleanConfig.AutoCleanDays = context.IntegerValue("GetLibrary.Library.AutoCleanConfig.AutoCleanDays");
			library.AutoCleanConfig = autoCleanConfig;
			getLibraryResponse.Library = library;
        
			return getLibraryResponse;
        }
    }
}