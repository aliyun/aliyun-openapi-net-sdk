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
using Aliyun.Acs.Slb.Model.V20140515;

namespace Aliyun.Acs.Slb.Transform.V20140515
{
    public class DescribeCACertificatesResponseUnmarshaller
    {
        public static DescribeCACertificatesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCACertificatesResponse describeCACertificatesResponse = new DescribeCACertificatesResponse();

			describeCACertificatesResponse.HttpResponse = _ctx.HttpResponse;
			describeCACertificatesResponse.RequestId = _ctx.StringValue("DescribeCACertificates.RequestId");

			List<DescribeCACertificatesResponse.DescribeCACertificates_CACertificate> describeCACertificatesResponse_cACertificates = new List<DescribeCACertificatesResponse.DescribeCACertificates_CACertificate>();
			for (int i = 0; i < _ctx.Length("DescribeCACertificates.CACertificates.Length"); i++) {
				DescribeCACertificatesResponse.DescribeCACertificates_CACertificate cACertificate = new DescribeCACertificatesResponse.DescribeCACertificates_CACertificate();
				cACertificate.RegionId = _ctx.StringValue("DescribeCACertificates.CACertificates["+ i +"].RegionId");
				cACertificate.CACertificateId = _ctx.StringValue("DescribeCACertificates.CACertificates["+ i +"].CACertificateId");
				cACertificate.CACertificateName = _ctx.StringValue("DescribeCACertificates.CACertificates["+ i +"].CACertificateName");
				cACertificate.Fingerprint = _ctx.StringValue("DescribeCACertificates.CACertificates["+ i +"].Fingerprint");
				cACertificate.ResourceGroupId = _ctx.StringValue("DescribeCACertificates.CACertificates["+ i +"].ResourceGroupId");
				cACertificate.CreateTime = _ctx.StringValue("DescribeCACertificates.CACertificates["+ i +"].CreateTime");
				cACertificate.CreateTimeStamp = _ctx.LongValue("DescribeCACertificates.CACertificates["+ i +"].CreateTimeStamp");
				cACertificate.ExpireTime = _ctx.StringValue("DescribeCACertificates.CACertificates["+ i +"].ExpireTime");
				cACertificate.ExpireTimeStamp = _ctx.LongValue("DescribeCACertificates.CACertificates["+ i +"].ExpireTimeStamp");
				cACertificate.CommonName = _ctx.StringValue("DescribeCACertificates.CACertificates["+ i +"].CommonName");
				cACertificate.EncryptionAlgorithm = _ctx.StringValue("DescribeCACertificates.CACertificates["+ i +"].EncryptionAlgorithm");
				cACertificate.EncryptionKeyLength = _ctx.IntegerValue("DescribeCACertificates.CACertificates["+ i +"].EncryptionKeyLength");
				cACertificate.StandardType = _ctx.StringValue("DescribeCACertificates.CACertificates["+ i +"].StandardType");

				List<DescribeCACertificatesResponse.DescribeCACertificates_CACertificate.DescribeCACertificates_Tag> cACertificate_tags = new List<DescribeCACertificatesResponse.DescribeCACertificates_CACertificate.DescribeCACertificates_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeCACertificates.CACertificates["+ i +"].Tags.Length"); j++) {
					DescribeCACertificatesResponse.DescribeCACertificates_CACertificate.DescribeCACertificates_Tag tag = new DescribeCACertificatesResponse.DescribeCACertificates_CACertificate.DescribeCACertificates_Tag();
					tag.TagKey = _ctx.StringValue("DescribeCACertificates.CACertificates["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = _ctx.StringValue("DescribeCACertificates.CACertificates["+ i +"].Tags["+ j +"].TagValue");

					cACertificate_tags.Add(tag);
				}
				cACertificate.Tags = cACertificate_tags;

				describeCACertificatesResponse_cACertificates.Add(cACertificate);
			}
			describeCACertificatesResponse.CACertificates = describeCACertificatesResponse_cACertificates;
        
			return describeCACertificatesResponse;
        }
    }
}
