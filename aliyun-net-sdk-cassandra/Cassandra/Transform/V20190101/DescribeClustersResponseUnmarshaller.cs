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
using Aliyun.Acs.Cassandra.Model.V20190101;

namespace Aliyun.Acs.Cassandra.Transform.V20190101
{
    public class DescribeClustersResponseUnmarshaller
    {
        public static DescribeClustersResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeClustersResponse describeClustersResponse = new DescribeClustersResponse();

			describeClustersResponse.HttpResponse = context.HttpResponse;
			describeClustersResponse.RequestId = context.StringValue("DescribeClusters.RequestId");
			describeClustersResponse.TotalCount = context.LongValue("DescribeClusters.TotalCount");
			describeClustersResponse.PageNumber = context.IntegerValue("DescribeClusters.PageNumber");
			describeClustersResponse.PageSize = context.IntegerValue("DescribeClusters.PageSize");

			List<DescribeClustersResponse.DescribeClusters_Cluster> describeClustersResponse_clusters = new List<DescribeClustersResponse.DescribeClusters_Cluster>();
			for (int i = 0; i < context.Length("DescribeClusters.Clusters.Length"); i++) {
				DescribeClustersResponse.DescribeClusters_Cluster cluster = new DescribeClustersResponse.DescribeClusters_Cluster();
				cluster.ClusterId = context.StringValue("DescribeClusters.Clusters["+ i +"].ClusterId");
				cluster.ClusterName = context.StringValue("DescribeClusters.Clusters["+ i +"].ClusterName");
				cluster.Status = context.StringValue("DescribeClusters.Clusters["+ i +"].Status");
				cluster.PayType = context.StringValue("DescribeClusters.Clusters["+ i +"].PayType");
				cluster.CreatedTime = context.StringValue("DescribeClusters.Clusters["+ i +"].CreatedTime");
				cluster.ExpireTime = context.StringValue("DescribeClusters.Clusters["+ i +"].ExpireTime");
				cluster.MajorVersion = context.StringValue("DescribeClusters.Clusters["+ i +"].MajorVersion");
				cluster.MinorVersion = context.StringValue("DescribeClusters.Clusters["+ i +"].MinorVersion");
				cluster.DataCenterCount = context.IntegerValue("DescribeClusters.Clusters["+ i +"].DataCenterCount");
				cluster.LockMode = context.StringValue("DescribeClusters.Clusters["+ i +"].LockMode");
				cluster.AutoRenewal = context.BooleanValue("DescribeClusters.Clusters["+ i +"].AutoRenewal");
				cluster.AutoRenewPeriod = context.IntegerValue("DescribeClusters.Clusters["+ i +"].AutoRenewPeriod");

				List<DescribeClustersResponse.DescribeClusters_Cluster.DescribeClusters_Tag> cluster_tags = new List<DescribeClustersResponse.DescribeClusters_Cluster.DescribeClusters_Tag>();
				for (int j = 0; j < context.Length("DescribeClusters.Clusters["+ i +"].Tags.Length"); j++) {
					DescribeClustersResponse.DescribeClusters_Cluster.DescribeClusters_Tag tag = new DescribeClustersResponse.DescribeClusters_Cluster.DescribeClusters_Tag();
					tag.Key = context.StringValue("DescribeClusters.Clusters["+ i +"].Tags["+ j +"].Key");
					tag._Value = context.StringValue("DescribeClusters.Clusters["+ i +"].Tags["+ j +"].Value");

					cluster_tags.Add(tag);
				}
				cluster.Tags = cluster_tags;

				describeClustersResponse_clusters.Add(cluster);
			}
			describeClustersResponse.Clusters = describeClustersResponse_clusters;
        
			return describeClustersResponse;
        }
    }
}
