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
    public class DescribeVulDetailsResponseUnmarshaller
    {
        public static DescribeVulDetailsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVulDetailsResponse describeVulDetailsResponse = new DescribeVulDetailsResponse();

			describeVulDetailsResponse.HttpResponse = _ctx.HttpResponse;
			describeVulDetailsResponse.RequestId = _ctx.StringValue("DescribeVulDetails.RequestId");

			List<DescribeVulDetailsResponse.DescribeVulDetails_Cve> describeVulDetailsResponse_cves = new List<DescribeVulDetailsResponse.DescribeVulDetails_Cve>();
			for (int i = 0; i < _ctx.Length("DescribeVulDetails.Cves.Length"); i++) {
				DescribeVulDetailsResponse.DescribeVulDetails_Cve cve = new DescribeVulDetailsResponse.DescribeVulDetails_Cve();
				cve.CveId = _ctx.StringValue("DescribeVulDetails.Cves["+ i +"].CveId");
				cve.CnvdId = _ctx.StringValue("DescribeVulDetails.Cves["+ i +"].CnvdId");
				cve.Title = _ctx.StringValue("DescribeVulDetails.Cves["+ i +"].Title");
				cve.CvssScore = _ctx.StringValue("DescribeVulDetails.Cves["+ i +"].CvssScore");
				cve.CvssVector = _ctx.StringValue("DescribeVulDetails.Cves["+ i +"].CvssVector");
				cve.ReleaseTime = _ctx.LongValue("DescribeVulDetails.Cves["+ i +"].ReleaseTime");
				cve.Complexity = _ctx.StringValue("DescribeVulDetails.Cves["+ i +"].Complexity");
				cve.Poc = _ctx.StringValue("DescribeVulDetails.Cves["+ i +"].Poc");
				cve.PocCreateTime = _ctx.LongValue("DescribeVulDetails.Cves["+ i +"].PocCreateTime");
				cve.PocDisclosureTime = _ctx.LongValue("DescribeVulDetails.Cves["+ i +"].PocDisclosureTime");
				cve.Summary = _ctx.StringValue("DescribeVulDetails.Cves["+ i +"].Summary");
				cve.Solution = _ctx.StringValue("DescribeVulDetails.Cves["+ i +"].Solution");
				cve.Content = _ctx.StringValue("DescribeVulDetails.Cves["+ i +"].Content");
				cve.Vendor = _ctx.StringValue("DescribeVulDetails.Cves["+ i +"].Vendor");
				cve.Product = _ctx.StringValue("DescribeVulDetails.Cves["+ i +"].Product");
				cve.VulLevel = _ctx.StringValue("DescribeVulDetails.Cves["+ i +"].VulLevel");
				cve.Reference = _ctx.StringValue("DescribeVulDetails.Cves["+ i +"].Reference");
				cve.Classify = _ctx.StringValue("DescribeVulDetails.Cves["+ i +"].Classify");

				List<DescribeVulDetailsResponse.DescribeVulDetails_Cve.DescribeVulDetails_Classify> cve_classifys = new List<DescribeVulDetailsResponse.DescribeVulDetails_Cve.DescribeVulDetails_Classify>();
				for (int j = 0; j < _ctx.Length("DescribeVulDetails.Cves["+ i +"].Classifys.Length"); j++) {
					DescribeVulDetailsResponse.DescribeVulDetails_Cve.DescribeVulDetails_Classify classify = new DescribeVulDetailsResponse.DescribeVulDetails_Cve.DescribeVulDetails_Classify();
					classify.Classify = _ctx.StringValue("DescribeVulDetails.Cves["+ i +"].Classifys["+ j +"].Classify");
					classify.Description = _ctx.StringValue("DescribeVulDetails.Cves["+ i +"].Classifys["+ j +"].Description");
					classify.DemoVideoUrl = _ctx.StringValue("DescribeVulDetails.Cves["+ i +"].Classifys["+ j +"].DemoVideoUrl");

					cve_classifys.Add(classify);
				}
				cve.Classifys = cve_classifys;

				describeVulDetailsResponse_cves.Add(cve);
			}
			describeVulDetailsResponse.Cves = describeVulDetailsResponse_cves;
        
			return describeVulDetailsResponse;
        }
    }
}
