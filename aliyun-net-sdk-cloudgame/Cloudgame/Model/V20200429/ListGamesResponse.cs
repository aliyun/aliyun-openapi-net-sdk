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
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.cloudgame.Model.V20200429
{
	public class ListGamesResponse : AcsResponse
	{

		private string count;

		private int? pageSize;

		private int? currentPage;

		private string requestId;

		private List<ListGames_DataListItem> dataList;

		public string Count
		{
			get
			{
				return count;
			}
			set	
			{
				count = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
			}
		}

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public List<ListGames_DataListItem> DataList
		{
			get
			{
				return dataList;
			}
			set	
			{
				dataList = value;
			}
		}

		public class ListGames_DataListItem
		{

			private string gameId;

			private string gameName;

			private string installPath;

			private string savePath;

			private string resolution;

			private string frameRate;

			private string inputType;

			private string device;

			private string status;

			private string curVersion;

			public string GameId
			{
				get
				{
					return gameId;
				}
				set	
				{
					gameId = value;
				}
			}

			public string GameName
			{
				get
				{
					return gameName;
				}
				set	
				{
					gameName = value;
				}
			}

			public string InstallPath
			{
				get
				{
					return installPath;
				}
				set	
				{
					installPath = value;
				}
			}

			public string SavePath
			{
				get
				{
					return savePath;
				}
				set	
				{
					savePath = value;
				}
			}

			public string Resolution
			{
				get
				{
					return resolution;
				}
				set	
				{
					resolution = value;
				}
			}

			public string FrameRate
			{
				get
				{
					return frameRate;
				}
				set	
				{
					frameRate = value;
				}
			}

			public string InputType
			{
				get
				{
					return inputType;
				}
				set	
				{
					inputType = value;
				}
			}

			public string Device
			{
				get
				{
					return device;
				}
				set	
				{
					device = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string CurVersion
			{
				get
				{
					return curVersion;
				}
				set	
				{
					curVersion = value;
				}
			}
		}
	}
}
