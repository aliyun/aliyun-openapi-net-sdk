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
using Aliyun.Acs.NAS.Model.V20170626;

namespace Aliyun.Acs.NAS.Transform.V20170626
{
    public class DescribeDirQuotasResponseUnmarshaller
    {
        public static DescribeDirQuotasResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDirQuotasResponse describeDirQuotasResponse = new DescribeDirQuotasResponse();

			describeDirQuotasResponse.HttpResponse = _ctx.HttpResponse;
			describeDirQuotasResponse.RequestId = _ctx.StringValue("DescribeDirQuotas.RequestId");
			describeDirQuotasResponse.TotalCount = _ctx.IntegerValue("DescribeDirQuotas.TotalCount");
			describeDirQuotasResponse.PageSize = _ctx.IntegerValue("DescribeDirQuotas.PageSize");
			describeDirQuotasResponse.PageNumber = _ctx.IntegerValue("DescribeDirQuotas.PageNumber");

			List<DescribeDirQuotasResponse.DescribeDirQuotas_DirQuotaInfo> describeDirQuotasResponse_dirQuotaInfos = new List<DescribeDirQuotasResponse.DescribeDirQuotas_DirQuotaInfo>();
			for (int i = 0; i < _ctx.Length("DescribeDirQuotas.DirQuotaInfos.Length"); i++) {
				DescribeDirQuotasResponse.DescribeDirQuotas_DirQuotaInfo dirQuotaInfo = new DescribeDirQuotasResponse.DescribeDirQuotas_DirQuotaInfo();
				dirQuotaInfo.Path = _ctx.StringValue("DescribeDirQuotas.DirQuotaInfos["+ i +"].Path");
				dirQuotaInfo.DirInode = _ctx.StringValue("DescribeDirQuotas.DirQuotaInfos["+ i +"].DirInode");
				dirQuotaInfo.Status = _ctx.StringValue("DescribeDirQuotas.DirQuotaInfos["+ i +"].Status");

				List<DescribeDirQuotasResponse.DescribeDirQuotas_DirQuotaInfo.DescribeDirQuotas_UserQuotaInfo> dirQuotaInfo_userQuotaInfos = new List<DescribeDirQuotasResponse.DescribeDirQuotas_DirQuotaInfo.DescribeDirQuotas_UserQuotaInfo>();
				for (int j = 0; j < _ctx.Length("DescribeDirQuotas.DirQuotaInfos["+ i +"].UserQuotaInfos.Length"); j++) {
					DescribeDirQuotasResponse.DescribeDirQuotas_DirQuotaInfo.DescribeDirQuotas_UserQuotaInfo userQuotaInfo = new DescribeDirQuotasResponse.DescribeDirQuotas_DirQuotaInfo.DescribeDirQuotas_UserQuotaInfo();
					userQuotaInfo.UserType = _ctx.StringValue("DescribeDirQuotas.DirQuotaInfos["+ i +"].UserQuotaInfos["+ j +"].UserType");
					userQuotaInfo.UserId = _ctx.StringValue("DescribeDirQuotas.DirQuotaInfos["+ i +"].UserQuotaInfos["+ j +"].UserId");
					userQuotaInfo.QuotaType = _ctx.StringValue("DescribeDirQuotas.DirQuotaInfos["+ i +"].UserQuotaInfos["+ j +"].QuotaType");
					userQuotaInfo.SizeLimit = _ctx.LongValue("DescribeDirQuotas.DirQuotaInfos["+ i +"].UserQuotaInfos["+ j +"].SizeLimit");
					userQuotaInfo.SizeReal = _ctx.LongValue("DescribeDirQuotas.DirQuotaInfos["+ i +"].UserQuotaInfos["+ j +"].SizeReal");
					userQuotaInfo.FileCountLimit = _ctx.LongValue("DescribeDirQuotas.DirQuotaInfos["+ i +"].UserQuotaInfos["+ j +"].FileCountLimit");
					userQuotaInfo.FileCountReal = _ctx.LongValue("DescribeDirQuotas.DirQuotaInfos["+ i +"].UserQuotaInfos["+ j +"].FileCountReal");

					dirQuotaInfo_userQuotaInfos.Add(userQuotaInfo);
				}
				dirQuotaInfo.UserQuotaInfos = dirQuotaInfo_userQuotaInfos;

				describeDirQuotasResponse_dirQuotaInfos.Add(dirQuotaInfo);
			}
			describeDirQuotasResponse.DirQuotaInfos = describeDirQuotasResponse_dirQuotaInfos;
        
			return describeDirQuotasResponse;
        }
    }
}
