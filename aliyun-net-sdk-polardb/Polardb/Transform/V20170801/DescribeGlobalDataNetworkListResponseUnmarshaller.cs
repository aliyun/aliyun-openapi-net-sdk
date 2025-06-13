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
using Aliyun.Acs.polardb.Model.V20170801;

namespace Aliyun.Acs.polardb.Transform.V20170801
{
    public class DescribeGlobalDataNetworkListResponseUnmarshaller
    {
        public static DescribeGlobalDataNetworkListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGlobalDataNetworkListResponse describeGlobalDataNetworkListResponse = new DescribeGlobalDataNetworkListResponse();

			describeGlobalDataNetworkListResponse.HttpResponse = _ctx.HttpResponse;
			describeGlobalDataNetworkListResponse.RequestId = _ctx.StringValue("DescribeGlobalDataNetworkList.RequestId");
			describeGlobalDataNetworkListResponse.TotalRecordCount = _ctx.StringValue("DescribeGlobalDataNetworkList.TotalRecordCount");
			describeGlobalDataNetworkListResponse.PageRecordCount = _ctx.StringValue("DescribeGlobalDataNetworkList.PageRecordCount");
			describeGlobalDataNetworkListResponse.PageNumber = _ctx.StringValue("DescribeGlobalDataNetworkList.PageNumber");
			describeGlobalDataNetworkListResponse.NextToken = _ctx.StringValue("DescribeGlobalDataNetworkList.NextToken");
			describeGlobalDataNetworkListResponse.MaxResults = _ctx.IntegerValue("DescribeGlobalDataNetworkList.MaxResults");

			DescribeGlobalDataNetworkListResponse.DescribeGlobalDataNetworkList_Items items = new DescribeGlobalDataNetworkListResponse.DescribeGlobalDataNetworkList_Items();

			List<DescribeGlobalDataNetworkListResponse.DescribeGlobalDataNetworkList_Items.DescribeGlobalDataNetworkList_Network> items_networks = new List<DescribeGlobalDataNetworkListResponse.DescribeGlobalDataNetworkList_Items.DescribeGlobalDataNetworkList_Network>();
			for (int i = 0; i < _ctx.Length("DescribeGlobalDataNetworkList.Items.Networks.Length"); i++) {
				DescribeGlobalDataNetworkListResponse.DescribeGlobalDataNetworkList_Items.DescribeGlobalDataNetworkList_Network network = new DescribeGlobalDataNetworkListResponse.DescribeGlobalDataNetworkList_Items.DescribeGlobalDataNetworkList_Network();
				network.NetworkId = _ctx.StringValue("DescribeGlobalDataNetworkList.Items.Networks["+ i +"].NetworkId");
				network.NetworkDescription = _ctx.StringValue("DescribeGlobalDataNetworkList.Items.Networks["+ i +"].NetworkDescription");
				network.NetworkStatus = _ctx.StringValue("DescribeGlobalDataNetworkList.Items.Networks["+ i +"].NetworkStatus");
				network.CreateTime = _ctx.StringValue("DescribeGlobalDataNetworkList.Items.Networks["+ i +"].CreateTime");

				DescribeGlobalDataNetworkListResponse.DescribeGlobalDataNetworkList_Items.DescribeGlobalDataNetworkList_Network.DescribeGlobalDataNetworkList_NetworkTopology networkTopology = new DescribeGlobalDataNetworkListResponse.DescribeGlobalDataNetworkList_Items.DescribeGlobalDataNetworkList_Network.DescribeGlobalDataNetworkList_NetworkTopology();

				List<DescribeGlobalDataNetworkListResponse.DescribeGlobalDataNetworkList_Items.DescribeGlobalDataNetworkList_Network.DescribeGlobalDataNetworkList_NetworkTopology.DescribeGlobalDataNetworkList_Source> networkTopology_sources = new List<DescribeGlobalDataNetworkListResponse.DescribeGlobalDataNetworkList_Items.DescribeGlobalDataNetworkList_Network.DescribeGlobalDataNetworkList_NetworkTopology.DescribeGlobalDataNetworkList_Source>();
				for (int j = 0; j < _ctx.Length("DescribeGlobalDataNetworkList.Items.Networks["+ i +"].NetworkTopology.Sources.Length"); j++) {
					DescribeGlobalDataNetworkListResponse.DescribeGlobalDataNetworkList_Items.DescribeGlobalDataNetworkList_Network.DescribeGlobalDataNetworkList_NetworkTopology.DescribeGlobalDataNetworkList_Source source = new DescribeGlobalDataNetworkListResponse.DescribeGlobalDataNetworkList_Items.DescribeGlobalDataNetworkList_Network.DescribeGlobalDataNetworkList_NetworkTopology.DescribeGlobalDataNetworkList_Source();
					source.SourceFileSystemPath = _ctx.StringValue("DescribeGlobalDataNetworkList.Items.Networks["+ i +"].NetworkTopology.Sources["+ j +"].SourceFileSystemPath");
					source.SourceType = _ctx.StringValue("DescribeGlobalDataNetworkList.Items.Networks["+ i +"].NetworkTopology.Sources["+ j +"].SourceType");
					source.SourceRegion = _ctx.StringValue("DescribeGlobalDataNetworkList.Items.Networks["+ i +"].NetworkTopology.Sources["+ j +"].SourceRegion");
					source.SourceId = _ctx.StringValue("DescribeGlobalDataNetworkList.Items.Networks["+ i +"].NetworkTopology.Sources["+ j +"].SourceId");

					networkTopology_sources.Add(source);
				}
				networkTopology.Sources = networkTopology_sources;

				List<DescribeGlobalDataNetworkListResponse.DescribeGlobalDataNetworkList_Items.DescribeGlobalDataNetworkList_Network.DescribeGlobalDataNetworkList_NetworkTopology.DescribeGlobalDataNetworkList_Destination> networkTopology_destinations = new List<DescribeGlobalDataNetworkListResponse.DescribeGlobalDataNetworkList_Items.DescribeGlobalDataNetworkList_Network.DescribeGlobalDataNetworkList_NetworkTopology.DescribeGlobalDataNetworkList_Destination>();
				for (int j = 0; j < _ctx.Length("DescribeGlobalDataNetworkList.Items.Networks["+ i +"].NetworkTopology.Destinations.Length"); j++) {
					DescribeGlobalDataNetworkListResponse.DescribeGlobalDataNetworkList_Items.DescribeGlobalDataNetworkList_Network.DescribeGlobalDataNetworkList_NetworkTopology.DescribeGlobalDataNetworkList_Destination destination = new DescribeGlobalDataNetworkListResponse.DescribeGlobalDataNetworkList_Items.DescribeGlobalDataNetworkList_Network.DescribeGlobalDataNetworkList_NetworkTopology.DescribeGlobalDataNetworkList_Destination();
					destination.DestinationFileSystemPath = _ctx.StringValue("DescribeGlobalDataNetworkList.Items.Networks["+ i +"].NetworkTopology.Destinations["+ j +"].DestinationFileSystemPath");
					destination.DestinationRegion = _ctx.StringValue("DescribeGlobalDataNetworkList.Items.Networks["+ i +"].NetworkTopology.Destinations["+ j +"].DestinationRegion");
					destination.DestinationType = _ctx.StringValue("DescribeGlobalDataNetworkList.Items.Networks["+ i +"].NetworkTopology.Destinations["+ j +"].DestinationType");
					destination.DestinationId = _ctx.StringValue("DescribeGlobalDataNetworkList.Items.Networks["+ i +"].NetworkTopology.Destinations["+ j +"].DestinationId");

					networkTopology_destinations.Add(destination);
				}
				networkTopology.Destinations = networkTopology_destinations;
				network.NetworkTopology = networkTopology;

				List<DescribeGlobalDataNetworkListResponse.DescribeGlobalDataNetworkList_Items.DescribeGlobalDataNetworkList_Network.DescribeGlobalDataNetworkList_Channel> network_channels = new List<DescribeGlobalDataNetworkListResponse.DescribeGlobalDataNetworkList_Items.DescribeGlobalDataNetworkList_Network.DescribeGlobalDataNetworkList_Channel>();
				for (int j = 0; j < _ctx.Length("DescribeGlobalDataNetworkList.Items.Networks["+ i +"].Channels.Length"); j++) {
					DescribeGlobalDataNetworkListResponse.DescribeGlobalDataNetworkList_Items.DescribeGlobalDataNetworkList_Network.DescribeGlobalDataNetworkList_Channel channel = new DescribeGlobalDataNetworkListResponse.DescribeGlobalDataNetworkList_Items.DescribeGlobalDataNetworkList_Network.DescribeGlobalDataNetworkList_Channel();
					channel.ChannelId = _ctx.StringValue("DescribeGlobalDataNetworkList.Items.Networks["+ i +"].Channels["+ j +"].ChannelId");
					channel.ChannelStatus = _ctx.StringValue("DescribeGlobalDataNetworkList.Items.Networks["+ i +"].Channels["+ j +"].ChannelStatus");
					channel.Progress = _ctx.StringValue("DescribeGlobalDataNetworkList.Items.Networks["+ i +"].Channels["+ j +"].Progress");
					channel.FreezeSourceDuringSync = _ctx.BooleanValue("DescribeGlobalDataNetworkList.Items.Networks["+ i +"].Channels["+ j +"].FreezeSourceDuringSync");

					network_channels.Add(channel);
				}
				network.Channels = network_channels;

				items_networks.Add(network);
			}
			items.Networks = items_networks;
			describeGlobalDataNetworkListResponse.Items = items;
        
			return describeGlobalDataNetworkListResponse;
        }
    }
}
