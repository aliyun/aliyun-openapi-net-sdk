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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeVulDetailsResponseUnmarshaller
    {
        public static DescribeVulDetailsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVulDetailsResponse describeVulDetailsResponse = new DescribeVulDetailsResponse();

			describeVulDetailsResponse.HttpResponse = context.HttpResponse;
			describeVulDetailsResponse.RequestId = context.StringValue("DescribeVulDetails.RequestId");

			List<DescribeVulDetailsResponse.DescribeVulDetails_Cve> describeVulDetailsResponse_cves = new List<DescribeVulDetailsResponse.DescribeVulDetails_Cve>();
			for (int i = 0; i < context.Length("DescribeVulDetails.Cves.Length"); i++) {
				DescribeVulDetailsResponse.DescribeVulDetails_Cve cve = new DescribeVulDetailsResponse.DescribeVulDetails_Cve();
				cve.CveId = context.StringValue("DescribeVulDetails.Cves["+ i +"].CveId");
				cve.CnvdId = context.StringValue("DescribeVulDetails.Cves["+ i +"].CnvdId");
				cve.OtherId = context.StringValue("DescribeVulDetails.Cves["+ i +"].OtherId");
				cve.Title = context.StringValue("DescribeVulDetails.Cves["+ i +"].Title");
				cve.CvssScore = context.StringValue("DescribeVulDetails.Cves["+ i +"].CvssScore");
				cve.CvssVector = context.StringValue("DescribeVulDetails.Cves["+ i +"].CvssVector");
				cve.ReleaseTime = context.LongValue("DescribeVulDetails.Cves["+ i +"].ReleaseTime");
				cve.Complexity = context.StringValue("DescribeVulDetails.Cves["+ i +"].Complexity");
				cve.Poc = context.StringValue("DescribeVulDetails.Cves["+ i +"].Poc");
				cve.PocCreateTime = context.LongValue("DescribeVulDetails.Cves["+ i +"].PocCreateTime");
				cve.PocDisclosureTime = context.LongValue("DescribeVulDetails.Cves["+ i +"].PocDisclosureTime");
				cve.Summary = context.StringValue("DescribeVulDetails.Cves["+ i +"].Summary");
				cve.Solution = context.StringValue("DescribeVulDetails.Cves["+ i +"].Solution");
				cve.Content = context.StringValue("DescribeVulDetails.Cves["+ i +"].Content");
				cve.Vendor = context.StringValue("DescribeVulDetails.Cves["+ i +"].Vendor");
				cve.Product = context.StringValue("DescribeVulDetails.Cves["+ i +"].Product");
				cve.VulLevel = context.StringValue("DescribeVulDetails.Cves["+ i +"].VulLevel");
				cve.Reference = context.StringValue("DescribeVulDetails.Cves["+ i +"].Reference");
				cve.Classify = context.StringValue("DescribeVulDetails.Cves["+ i +"].Classify");

				List<DescribeVulDetailsResponse.DescribeVulDetails_Cve.DescribeVulDetails_Classify> cve_classifys = new List<DescribeVulDetailsResponse.DescribeVulDetails_Cve.DescribeVulDetails_Classify>();
				for (int j = 0; j < context.Length("DescribeVulDetails.Cves["+ i +"].Classifys.Length"); j++) {
					DescribeVulDetailsResponse.DescribeVulDetails_Cve.DescribeVulDetails_Classify classify = new DescribeVulDetailsResponse.DescribeVulDetails_Cve.DescribeVulDetails_Classify();
					classify.Classify = context.StringValue("DescribeVulDetails.Cves["+ i +"].Classifys["+ j +"].Classify");
					classify.Description = context.StringValue("DescribeVulDetails.Cves["+ i +"].Classifys["+ j +"].Description");
					classify.DemoVideoUrl = context.StringValue("DescribeVulDetails.Cves["+ i +"].Classifys["+ j +"].DemoVideoUrl");

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
