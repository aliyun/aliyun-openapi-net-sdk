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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeAffectedMaliciousFileImagesResponseUnmarshaller
    {
        public static DescribeAffectedMaliciousFileImagesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAffectedMaliciousFileImagesResponse describeAffectedMaliciousFileImagesResponse = new DescribeAffectedMaliciousFileImagesResponse();

			describeAffectedMaliciousFileImagesResponse.HttpResponse = _ctx.HttpResponse;
			describeAffectedMaliciousFileImagesResponse.RequestId = _ctx.StringValue("DescribeAffectedMaliciousFileImages.RequestId");

			DescribeAffectedMaliciousFileImagesResponse.DescribeAffectedMaliciousFileImages_PageInfo pageInfo = new DescribeAffectedMaliciousFileImagesResponse.DescribeAffectedMaliciousFileImages_PageInfo();
			pageInfo.CurrentPage = _ctx.IntegerValue("DescribeAffectedMaliciousFileImages.PageInfo.CurrentPage");
			pageInfo.PageSize = _ctx.IntegerValue("DescribeAffectedMaliciousFileImages.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.IntegerValue("DescribeAffectedMaliciousFileImages.PageInfo.TotalCount");
			pageInfo.Count = _ctx.IntegerValue("DescribeAffectedMaliciousFileImages.PageInfo.Count");
			describeAffectedMaliciousFileImagesResponse.PageInfo = pageInfo;

			List<DescribeAffectedMaliciousFileImagesResponse.DescribeAffectedMaliciousFileImages_AffectedMaliciousFileImage> describeAffectedMaliciousFileImagesResponse_affectedMaliciousFileImagesResponse = new List<DescribeAffectedMaliciousFileImagesResponse.DescribeAffectedMaliciousFileImages_AffectedMaliciousFileImage>();
			for (int i = 0; i < _ctx.Length("DescribeAffectedMaliciousFileImages.AffectedMaliciousFileImagesResponse.Length"); i++) {
				DescribeAffectedMaliciousFileImagesResponse.DescribeAffectedMaliciousFileImages_AffectedMaliciousFileImage affectedMaliciousFileImage = new DescribeAffectedMaliciousFileImagesResponse.DescribeAffectedMaliciousFileImages_AffectedMaliciousFileImage();
				affectedMaliciousFileImage.Status = _ctx.IntegerValue("DescribeAffectedMaliciousFileImages.AffectedMaliciousFileImagesResponse["+ i +"].Status");
				affectedMaliciousFileImage.Digest = _ctx.StringValue("DescribeAffectedMaliciousFileImages.AffectedMaliciousFileImagesResponse["+ i +"].Digest");
				affectedMaliciousFileImage.LatestVerifyTimestamp = _ctx.LongValue("DescribeAffectedMaliciousFileImages.AffectedMaliciousFileImagesResponse["+ i +"].LatestVerifyTimestamp");
				affectedMaliciousFileImage.RepoInstanceId = _ctx.StringValue("DescribeAffectedMaliciousFileImages.AffectedMaliciousFileImagesResponse["+ i +"].RepoInstanceId");
				affectedMaliciousFileImage._Namespace = _ctx.StringValue("DescribeAffectedMaliciousFileImages.AffectedMaliciousFileImagesResponse["+ i +"].Namespace");
				affectedMaliciousFileImage.Tag = _ctx.StringValue("DescribeAffectedMaliciousFileImages.AffectedMaliciousFileImagesResponse["+ i +"].Tag");
				affectedMaliciousFileImage.RepoRegionId = _ctx.StringValue("DescribeAffectedMaliciousFileImages.AffectedMaliciousFileImagesResponse["+ i +"].RepoRegionId");
				affectedMaliciousFileImage.ImageUuid = _ctx.StringValue("DescribeAffectedMaliciousFileImages.AffectedMaliciousFileImagesResponse["+ i +"].ImageUuid");
				affectedMaliciousFileImage.FirstScanTimestamp = _ctx.LongValue("DescribeAffectedMaliciousFileImages.AffectedMaliciousFileImagesResponse["+ i +"].FirstScanTimestamp");
				affectedMaliciousFileImage.MaliciousMd5 = _ctx.StringValue("DescribeAffectedMaliciousFileImages.AffectedMaliciousFileImagesResponse["+ i +"].MaliciousMd5");
				affectedMaliciousFileImage.FilePath = _ctx.StringValue("DescribeAffectedMaliciousFileImages.AffectedMaliciousFileImagesResponse["+ i +"].FilePath");
				affectedMaliciousFileImage.RepoId = _ctx.StringValue("DescribeAffectedMaliciousFileImages.AffectedMaliciousFileImagesResponse["+ i +"].RepoId");
				affectedMaliciousFileImage.Layer = _ctx.StringValue("DescribeAffectedMaliciousFileImages.AffectedMaliciousFileImagesResponse["+ i +"].Layer");
				affectedMaliciousFileImage.LatestScanTimestamp = _ctx.LongValue("DescribeAffectedMaliciousFileImages.AffectedMaliciousFileImagesResponse["+ i +"].LatestScanTimestamp");
				affectedMaliciousFileImage.RepoName = _ctx.StringValue("DescribeAffectedMaliciousFileImages.AffectedMaliciousFileImagesResponse["+ i +"].RepoName");
				affectedMaliciousFileImage.Level = _ctx.StringValue("DescribeAffectedMaliciousFileImages.AffectedMaliciousFileImagesResponse["+ i +"].Level");
				affectedMaliciousFileImage.DownloadUrl = _ctx.StringValue("DescribeAffectedMaliciousFileImages.AffectedMaliciousFileImagesResponse["+ i +"].DownloadUrl");
				affectedMaliciousFileImage.HighLight = _ctx.StringValue("DescribeAffectedMaliciousFileImages.AffectedMaliciousFileImagesResponse["+ i +"].HighLight");

				describeAffectedMaliciousFileImagesResponse_affectedMaliciousFileImagesResponse.Add(affectedMaliciousFileImage);
			}
			describeAffectedMaliciousFileImagesResponse.AffectedMaliciousFileImagesResponse = describeAffectedMaliciousFileImagesResponse_affectedMaliciousFileImagesResponse;
        
			return describeAffectedMaliciousFileImagesResponse;
        }
    }
}
